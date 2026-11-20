using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class CreditcardDetails:IPayment
    {
        private string Cardnumber { get; set; }
        private string Cvv { get; set; }

        private string Cardholdername { get; set; }

        public CreditcardDetails(string cardnumber)
        {
            if (isValidate())
            {
                Cardnumber = cardnumber;
            }
        }
        public string cvv
        {
            set
            {
                if(isValidate())
                {
                    Cvv = value;
                }
            }
        }
        public void Setholdername(string cardholdername)
        {
              if(isValidate())
                {
                    Cardholdername = cardholdername;
                }            
        }
        public bool isValidate()
        {
            //logic
            return true;
        }

        public void ProcessPayment(double Amount)
        {
            if(!string.IsNullOrEmpty(Cardnumber) && !string.IsNullOrEmpty(Cvv) && !string.IsNullOrEmpty(Cardholdername))
            {
                Console.WriteLine($"Processing payment of {Amount} using credit card...");
            }
            else
            {
                Console.WriteLine("Credit card details are incomplete. Cannot process payment.");
            }
           // Console.WriteLine("Processed paymentsuccessfully.");
            // Add logic to process payment using credit card details
        }



        

    }
}
