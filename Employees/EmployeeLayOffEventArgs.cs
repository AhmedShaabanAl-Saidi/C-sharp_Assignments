using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_C_.Employees
{
    public class EmployeeLayOffEventArgs : EventArgs
    {
        public LayOffCause Cause { get; set; }
    }
}
