using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class Overriding
    {
        //overriding - same method different implementation
        public class Employees
        {
            public virtual void Salary()
            {
                Console.WriteLine("Employee salary: 20000");
            }
        }
        public class Developer : Employees
        {
            public override void Salary()
            {
                Console.WriteLine("Developer salary: 40000");
            }
        }
    }
}
