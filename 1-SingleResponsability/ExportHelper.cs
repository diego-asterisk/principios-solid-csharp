using System.Text;
using System.Reflection;

namespace SingleResponsability
{
    public class ExportHelper
    {
        public void ExportStudents(IEnumerable<Student> students) 
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            sb.AppendLine("Id; Fullname; Grades");
            
            foreach (var item in students)
            {
                sb.AppendLine($"{item.Id};{item.Fullname};{string.Join("|", item.Grades)}");
            }
            System.IO.File.WriteAllText(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Students.csv"), sb.ToString(), Encoding.UTF8);
        }

            public void Export<T>(string header, IEnumerable<T> registers) 
            {

                System.Text.StringBuilder sb = new System.Text.StringBuilder();

                sb.AppendLine(header);
                
                foreach (var item in registers)
                {
                    if (item == null) continue;
                    Type type = item.GetType();
                    PropertyInfo[] props = type.GetProperties();
                    string lineaCsv = "";
                    foreach (var prop in props)
                    {
                        lineaCsv+= prop.GetValue(item) + ";";
                    }

                    sb.AppendLine(lineaCsv);
                }
                System.IO.File.WriteAllText(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Registers.csv"), sb.ToString(), Encoding.UTF8);
            }
        
    

    }
}