using SingleResponsability;

StudentRepository studentRepository = new();
ExportHelper exportHelper = new();
exportHelper.ExportStudents(studentRepository.GetAll());
exportHelper.Export("ID;NOMBRE;Grado",studentRepository.GetAll());
Console.WriteLine("Proceso Completado");