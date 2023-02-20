using OpenClose;

ShowSalaryMonthly(new List<IEmployee>() {
    new EmployeeFullTime("Pepito Pérez", 160),
    new EmployeeContractor("Mariana Gómez", 140),
    new EmployeePartTime("Manuel Lopera", 180)
});


void ShowSalaryMonthly(List<IEmployee> employees) 
{
    foreach (var employee in employees)
    {
        var salary = employee.CalculateSalaryMonthly();
        Console.WriteLine($"Empleado: {employee.Fullname}, Pago: {salary:C1} ");
    }

}