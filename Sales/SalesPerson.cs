using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment1_C_.Employees;

namespace Assignment1_C_.Sales
{
    public class SalesPerson : Employee
    {
        public int AchievedTarget { get; set; }

        public bool CheckTarget(int quota)
        {
            return AchievedTarget >= quota;
        }

        public void EvaluateLayOff()
        {
            if (!CheckTarget(10)) 
            {
                RaiseLayOffEvent(LayOffCause.FailedTarget); 
            }
        }
    }
}
