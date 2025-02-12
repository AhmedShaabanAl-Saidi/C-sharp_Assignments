namespace Assignment1_C_.Employee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee { EmployeeID = 1, BirthDate = new DateTime(1999, 1, 1), VacationStock = 10 };

            employee.OnEmployeeLayOff += employee.EndOfYearOperation;

            Console.WriteLine("*** End Of Year Operation ***");
            employee.BirthDate = new DateTime(1960, 1, 1);

            Console.WriteLine("*** End Vacation Stock ***");
            employee.VacationStock = -1; 

        }
    }
}
