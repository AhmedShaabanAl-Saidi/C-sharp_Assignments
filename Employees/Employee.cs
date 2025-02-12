using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_C_.Employees
{
    public class Employee
    {
        public int EmployeeID { get; set; }

        private DateTime birthDate;
        public DateTime BirthDate
        {
            get { return birthDate; }
            set
            {
                birthDate = value;

                if ((DateTime.Now.Year - BirthDate.Year) > 60)
                    OnEmployeeLayOff?.Invoke(this, new EmployeeLayOffEventArgs { Cause = LayOffCause.Age });
            }
        }

        private int vacationStock;
        public int VacationStock
        {
            get { return vacationStock; }
            set
            {
                vacationStock = value;

                if (vacationStock < 0)
                    OnEmployeeLayOff?.Invoke(this, new EmployeeLayOffEventArgs { Cause = LayOffCause.VacationStock });
            }
        }

        public bool RequestVacation(DateTime from, DateTime to)
        {
            int daysRequested = (to - from).Days;

            if (daysRequested <= vacationStock)
            {
                VacationStock -= daysRequested;
                return true;
            }

            OnEmployeeLayOff?.Invoke(this, new EmployeeLayOffEventArgs { Cause = LayOffCause.VacationStock });
            return false;
        }

        public void EndOfYearOperation(object? sender, EmployeeLayOffEventArgs employeeLayOffEvent)
        {
            if (sender is Employee employeeSender)
                Console.WriteLine($"Employee Lay off because of : {employeeLayOffEvent.Cause}");
        }

        // EventHandler
        public event EventHandler<EmployeeLayOffEventArgs>? OnEmployeeLayOff;
    }
}
