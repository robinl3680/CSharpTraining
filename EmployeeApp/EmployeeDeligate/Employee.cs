using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDeligate
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public Employee() { }
        public Employee(int id, string name, decimal salary)
        {
            this.Name = name;
            this.Salary = salary;
            this.Id = id;
        }
        public override string ToString()
        {
            return $"Name : {Name} , Id : {Id} , Salary : {Salary}";
        }
    }
}
