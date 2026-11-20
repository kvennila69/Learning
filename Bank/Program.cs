using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Bank
{
    public class Program
    {
        static void Main(string[] args)
        {
            //CreditcardDetails creditcard = new CreditcardDetails("12345");
            //creditcard.cvv = "9966";
            //creditcard.Setholdername ("Vennila"); 
            ////creditcard.Cvv = "123";
            //creditcard.ProcessPayment(100000.0);
            //Console.ReadLine();

            //Overriding

            //Overriding overriding = new Overriding();
            //Overriding.Developer developer = new Overriding.Developer();
            //developer.Salary();
            //List<string> fruits = new List<string> { "Mango", "Apple", "Banana" };
            //string fruit;

            Console.WriteLine("Enter the number of employees:");
            int noofemp = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine(); //always returns string


            ArrayList arraylist = new ArrayList();
            arraylist.Add("Vennila");
            arraylist.Add(10);
            Console.WriteLine(arraylist.Count);
            Console.ReadLine();
           
        }
    }
}
