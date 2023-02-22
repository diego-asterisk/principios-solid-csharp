using System.Text;

namespace DependencyInversion
{
    public interface ILogbook
    {
        void Add(string description);
    }
    public class Logbook: ILogbook
    {
        public void Add(string description)
        {
            File.AppendAllText(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "logbook.txt"), $"{description}\n", Encoding.Unicode);
        }
    }
}