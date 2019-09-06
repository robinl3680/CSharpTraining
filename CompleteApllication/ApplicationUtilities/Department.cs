using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationUtilities
{
    public class Department
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public Department()
        {

        }
        public Department(int id, string name)
        {
            Name = name;
            Id = id;
        }
    }
}
