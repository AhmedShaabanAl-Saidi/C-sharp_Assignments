using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment1_C_.Employees;

namespace Assignment1_C_.Departments
{
    public class Department
    {
        public int DeptID { get; set; }
        public string DeptName { get; set; }

        List<Employee> Staff = new List<Employee>();

        public void AddStaff(Employee employee)
        {
            ///Try Register for EmployeeLayOff Event Here
            employee.OnEmployeeLayOff += RemoveStaff;
            Staff.Add(employee);
        }

        ///CallBackMethod
        public void RemoveStaff(object sender, EmployeeLayOffEventArgs employeeLayOffEvent)
        {
            if (sender is Employee employee)
            {
                Staff.Remove(employee);
                Console.WriteLine($"Employee {employee.EmployeeID} removed from department {DeptName} because of : {employeeLayOffEvent.Cause}");
            }
        }
    }
}
