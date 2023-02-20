namespace OpenClose
{
    interface IEmployee
    {
        decimal CalculateSalaryMonthly();
        string Fullname { get; set; }
    }
    public abstract class Employee: IEmployee
    {
        public string Fullname { get; set; } = "";
        public int HoursWorked { get; set; }
        public abstract decimal CalculateSalaryMonthly();
    }
}