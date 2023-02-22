using Xunit;
using DependencyInversion.Controllers;
using Moq;
using DependencyInversion;

namespace Api.Tests;


public class StudentTest 
{
/*  [Fact]
    public void GetStudent()
    {
        var studentController = new StudentController();

        var resultGetStudents = studentController.Get();

        Assert.NotNull(resultGetStudents);
        Assert.Equal(3, resultGetStudents.Count());
    }
*/
    // Agregar DI
        // crear una interfaz para el repositorio y que el repositorio implemente la interfaz formalmente
        // crear una interfaz para el modelo logbook y que el modelo logbook implemente la interfaz
        // en el controller usamos las interfaces y las inyectamos en el constructor (comentamos la creacion de las variables viejas)
        // para crear el controller con los objetos que necesita se usa el builder.Services de .Net que los injecta en el constructor que los necesita
            // en Program.cs 
                // builder.Services.AddTransient<IStudentRepository, StudentRepository>();// siempre diferente
                // builder.Services.AddScoped<ILogbook, Logbook>();    // siempre el mismo en el mismo request, pero diferente en otros request
                // builder.Services.AddSingleton<IStudentRepository, StudentRepository>();// siempre el mismo objeto
        // luego comentamos la version original del test y la reemplazamos por una que usa objetos Mock


     [Fact]
    public void GetStudent()
    {
         var logbookMock = new Mock<ILogbook>();
         var stundentRepositoryMock = new Mock<IStudentRepository>();
         stundentRepositoryMock.Setup(p=> p.GetAll())
                                         .Returns(new List<Student>()
                                         {
                                             new Student(1, "Pepito Pérez", new List<double>() { 3, 4.5 }),
                                             new Student(2, "Mariana Lopera", new List<double>() { 4, 5 }),
                                             new Student(3, "José Molina", new List<double>() { 2, 3 })
                                         });

         var studentController = new StudentController(stundentRepositoryMock.Object, logbookMock.Object);

         var resultGetStudents = studentController.Get();

         Assert.NotNull(resultGetStudents);
         Assert.Equal(3, resultGetStudents.Count());
    }
}