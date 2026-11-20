using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{

    public abstract class Employee
    {
        public void Employeesdetails()
        {
            Console.WriteLine("Employee details added successfully...");
        }
        public void EMS()
        {
            Console.WriteLine("In and out time of employee is recorded successfully...");
        }
        public abstract void Work();
        public abstract void Salary();

    }
    public abstract class Trainee : Employee
    {
        public override void Work()
        {
            Console.WriteLine("Trainee is working...");
        }
        public override void Salary()
        {
           Console.WriteLine ("Trainee salary calculated");         
        }

    }

    //work - same method different implementation
    //salary - same method different implementation

    
    public abstract class TL:Employee
    {
        public override void Work()
        {
            Console.WriteLine("TL is working");
        }
        public override void Salary()
        {
            Console.WriteLine("TL salary calculated");
        }
    }
    public abstract class Manager:Employee
    {
        public override void Work()
        {
            Console.WriteLine("Manager is working");

        }
        public override void Salary()
        {
            Console.WriteLine("Manager salary calculated");
        }
        public void FireEmployee()
        {
            Console.WriteLine("Employee fired successfully...");
        }

    }

    public interface IFireoption
    {
        void FireEmployee();
    }
}
