using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment1_C_.Employees;

namespace Assignment1_C_.Clubs
{
    public class Club
    {
        public int ClubID { get; set; }
        public String ClubName { get; set; }
        List<Employee> Members = new List<Employee>();
        public void AddMember(Employee employee)
        {
            ///Try Register for EmployeeLayOff Event Here
            employee.OnEmployeeLayOff += RemoveMember;

            Members.Add(employee);
        }
        ///CallBackMethod
        public void RemoveMember(object sender, EmployeeLayOffEventArgs employeeLayOffEvent)
        {
            ///Employee will be removed from Club if Vacation Stock < 0
            if (sender is Employee employee)
            {
                if (employeeLayOffEvent.Cause == LayOffCause.Age)
                {
                    Console.WriteLine($"Employee {employee.EmployeeID} removed from Club {ClubName} because of : {employeeLayOffEvent.Cause}");
                    Members.Remove(employee);
                }
                else
                {
                    ///Employee Will not be removed from the Club if Age>60
                    Console.WriteLine($"Employee {employee.EmployeeID} Will not be removed {ClubName}");
                }
            }
        }
    }
}