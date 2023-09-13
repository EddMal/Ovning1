using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Ovning1
{
    internal class Employee
    {
        public string Name { get; set; }
        public int Salary { get; }

        public Employee(string name, int salary) 
        {
            Name = name;
            Salary = salary;
        }
    }
}
