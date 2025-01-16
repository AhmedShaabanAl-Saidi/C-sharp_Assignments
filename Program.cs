using Assignment1_C_.Inheritance;
using Assignment1_C_.Part2_Employee;
using Assignment1_C_.Part2_Employee.Enums;

namespace Assignment1_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 1
            //Child child = new Child(10,20,30);

            //int result = child.ProductOfNumbers();

            //Console.WriteLine(result);
            #endregion

            #region Part 2
            #region Part 01
            //Employee employee = new Employee(1, "Ahmed", SecurityPrivileges.Developer, 12000, new DateTime(2024, 1, 15), Gender.M);

            //Console.WriteLine(employee);
            //Console.WriteLine(employee.GetEmployeeSalary());
            #endregion

            #region Part 02
            //HiringDate hiringDate = new HiringDate(15,1,2024);

            //Console.WriteLine(hiringDate);
            #endregion

            #region Part 03
            Employee[] EmpArr = new Employee[3];

            Employee emp1 = EmpArr[0];
            emp1.ID = 1;
            emp1.Name = "Ahmed";
            emp1.SecurityLevel = SecurityPrivileges.DBA;
            emp1.Salary = 20000;
            emp1.HireDate = new DateTime(2024,1,10);
            emp1.Gender = Gender.M;

            Employee emp2 = EmpArr[1];
            emp2.ID = 2;
            emp2.Name = "Ali";
            emp2.SecurityLevel = SecurityPrivileges.Guest;
            emp2.Salary = 15000;
            emp2.HireDate = new DateTime(2024, 1, 12);
            emp2.Gender = Gender.M;

            Employee emp3 = EmpArr[2];
            emp3.ID = 3;
            emp3.Name = "Mohmed";
            emp3.SecurityLevel = SecurityPrivileges.Secretary;
            emp3.Salary = 12000;
            emp3.HireDate = new DateTime(2024, 1, 15);
            emp3.Gender = Gender.M;
            #endregion


            #endregion
        }
    }
}
