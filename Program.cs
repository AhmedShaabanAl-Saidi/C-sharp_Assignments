using Assignment1_C_.Board;
using Assignment1_C_.Clubs;
using Assignment1_C_.Departments;
using Assignment1_C_.Employees;
using Assignment1_C_.Sales;

namespace Assignment1_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Employee

            //Employee employee = new Employee { EmployeeID = 1, BirthDate = new DateTime(1999, 1, 1), VacationStock = 10 };

            //employee.OnEmployeeLayOff += employee.EndOfYearOperation;

            //Console.WriteLine("*** End Of Year Operation ***");
            //employee.BirthDate = new DateTime(1960, 1, 1);

            //Console.WriteLine("*** End Vacation Stock ***");
            //employee.VacationStock = -1;

            //Department

            //Department ITDepartment = new Department { DeptID = 1, DeptName = "IT" };
            //Employee employee1 = new Employee { EmployeeID = 101, BirthDate = new DateTime(1955, 1, 1), VacationStock = 5 };
            //Employee employee2 = new Employee { EmployeeID = 102, BirthDate = new DateTime(1990, 1, 1), VacationStock = -2 };
            //Employee employee3 = new Employee { EmployeeID = 103, BirthDate = new DateTime(1999, 1, 1), VacationStock = 8 };

            //ITDepartment.AddStaff(employee1);
            //ITDepartment.AddStaff(employee2);
            //ITDepartment.AddStaff(employee3);

            //employee1.BirthDate = new DateTime(1960, 1, 1);
            //employee2.VacationStock = -5;
            //employee3.BirthDate = new DateTime(1955, 1, 22);

            //Club
            //Club companyClub = new Club { ClubID = 1, ClubName = "Company Club" };

            //Employee employee1 = new Employee { EmployeeID = 101, BirthDate = new DateTime(1955, 1, 1), VacationStock = 5 };
            //Employee employee2 = new Employee { EmployeeID = 102, BirthDate = new DateTime(1990, 1, 1), VacationStock = -2 };

            //companyClub.AddMember(employee1);
            //companyClub.AddMember(employee2);

            //employee1.BirthDate = new DateTime(1960, 1, 1);
            //employee2.VacationStock = -5;

            //Sales Employee & Board Member

            //Club companyClub = new Club { ClubID = 1, ClubName = "Company Club" };

            //SalesPerson salesEmployee = new SalesPerson { EmployeeID = 201, AchievedTarget = 5 };
            //BoardMember boardMember = new BoardMember { EmployeeID = 301 };

            //salesEmployee.OnEmployeeLayOff += salesEmployee.HandleEmployeeLayOff;
            //boardMember.OnEmployeeLayOff += boardMember.HandleEmployeeLayOff;

            //boardMember.OnEmployeeLayOff += companyClub.RemoveMember;

            //salesEmployee.EvaluateLayOff();
            //boardMember.Resign();
        }
    }
}
