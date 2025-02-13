using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment1_C_.Employees;

namespace Assignment1_C_.Board
{
    public class BoardMember : Employee
    {
        public void Resign()
        {
            RaiseLayOffEvent(LayOffCause.Resignation);
        }
    }
}
