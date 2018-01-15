using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        int A;

        public void message()
        {
            int B;
           // B = 0;
            Console.Write(A + "\n");
            Console.Write(B);
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            Program x;
            x = new Program();
            x.message();
        }
    }
}
