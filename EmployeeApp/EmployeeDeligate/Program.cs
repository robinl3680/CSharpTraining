using System;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeDeligate
{
    class Program
    {
        static void Main()
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee(1,"Robin",480000),
                new Employee(2,"Kiran",5030),
                new Employee(3,"Viswa",45000)
            };

            Func<Employee, bool> salaryCheck = (emp) => emp.Name.Contains('n');
            Func<Employee, decimal> sortLogic = (emp) => emp.Salary;
            Action<Employee> printEmployee = (emp) => Console.WriteLine(emp);

            employees.Where(salaryCheck).OrderBy(sortLogic).ToList<Employee>().ForEach(printEmployee);


            var query = from e in employees
                        where e.Name.Contains('n')
                        orderby e.Salary ascending
                        select e;
            foreach (var item in query)
                Console.WriteLine(item);
        }
    }
}
