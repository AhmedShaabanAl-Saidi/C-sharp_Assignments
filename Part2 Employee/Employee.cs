using Assignment1_C_.Part2_Employee.Enums;

namespace Assignment1_C_.Part2_Employee
{
    public class Employee
    {
        public int ID {  get; set; }
        public string Name { get; set; }
        public SecurityPrivileges SecurityLevel { get; set; }
        public decimal Salary { get; set; }
        public HiringDate HireDate { get; set; }
        public Gender Gender { get; set; }

        public Employee(int _id , string _name , SecurityPrivileges _SecurityLevel , decimal _salary , HiringDate _hireDate , Gender _gender) 
        {
            ID = _id ;
            Name = _name ;
            SecurityLevel = _SecurityLevel ;
            Salary = _salary ;
            HireDate = _hireDate ;
            Gender = _gender ;
        }

        public override string ToString()
        {
            return $"ID: {ID}, Name: {Name}, Gender: {Gender}, Security Level: {SecurityLevel}, Salary: {Salary:C}, Hire Date: {HireDate:yyyy-MM-dd}";
        }

        public string GetEmployeeSalary()
        {
            return string.Format("Employee {0} , Salary {1:C}", Name, Salary);
        }

    }
}
