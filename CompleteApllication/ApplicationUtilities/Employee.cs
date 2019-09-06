using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationUtilities
{
    public class Employee
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string Location { get; set; }
        public decimal Salary { get; set; }
        public Employee()
        {

        }
        public Employee(string name, int id, decimal salary, string location)
        {
            Name = name;
            Id = id;
            Location = location;
            Salary = salary;
        }
    }
}
