using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class One
    {
        int A;
        public void message()
        {
            Console.Write("ABC");
        }
    }

    class Two : One
    { 
        int x;
        public void message2()
        {
            Console.Write("123");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            One x;
            x = new Two();
            x.message();
            x.message2();
        }
    }
}
