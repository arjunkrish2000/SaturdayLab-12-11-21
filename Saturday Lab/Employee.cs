using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saturday_Lab
{
    internal class Employee
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public string Designation { get; set; }
        private int _salary;

        public void ForSalary()
        {
            Designation = Designation.ToLower();    
            if (Designation.Equals("trainee"))
            {
                _salary = 5000;
                Console.WriteLine($"Salary : {_salary}");
            }
            else {
                _salary = 11000;
                Console.WriteLine($"Salary : {_salary}");
            }
        }
    }
}
