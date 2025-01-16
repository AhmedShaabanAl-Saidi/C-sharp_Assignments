using System.Diagnostics;
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

            EmpArr[0] = new Employee(1, "Ahmed", SecurityPrivileges.DBA, 20000, new HiringDate(12, 1, 2024), Gender.M);
            EmpArr[1] = new Employee(2, "Ali", SecurityPrivileges.Guest, 15000, new HiringDate(10, 1, 2024), Gender.M);
            EmpArr[2] = new Employee(3, "Mohmed", SecurityPrivileges.Secretary, 12000, new HiringDate(15, 1, 2024), Gender.M);
            #endregion

            #region Part 04
            Employee[] sortedEmpArr = EmpArr.OrderBy(e => new DateTime(e.HireDate.Year, e.HireDate.Month, e.HireDate.Day)).ToArray();


            foreach (Employee employee in sortedEmpArr)
            {
                Console.WriteLine(employee);
            }

            // While sorting(how many times Boxing and Unboxing process has occurred)
            // boxing and unboxing will occur O(n log n) times
            #endregion
            #endregion
        }
    }
}
