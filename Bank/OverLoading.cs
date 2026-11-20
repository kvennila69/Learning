using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Bank
{
    public class OverLoading
    {
        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }
        public int Add(int b, int c)
        {
            return b + c;
        }
        public double Add(double a, int c)
        {
            return a + c;
        }

        public string Add(string a,string b)
        {
            return a + b;
        }

    }
}
