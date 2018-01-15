using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{ 
    class Bank
    {
        static int Dollar;

        public void Amount(int a)
        {
            Console.Write(a * Dollar + "\n");
            Console.ReadKey();
        }

        public void SetDollar(int b)
        {
            Dollar = b;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Bank HSBC, NatWest, Barclays;
            HSBC = new Bank();
            NatWest = new Bank();
            Barclays = new Bank();

            HSBC.SetDollar(100);
            NatWest.Amount(100);
            Barclays.Amount(200);
            NatWest.SetDollar(1);
            HSBC.Amount(2);
            Barclays.Amount(1000);
        }
    }
}
