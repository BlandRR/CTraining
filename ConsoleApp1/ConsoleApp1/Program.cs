using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Results
    {
       public int Maths;
       public float Percentage;

        /**
        public Results(int Maths, float Percentage)
        {
            this.Maths = Maths;
            this.Percentage = Percentage;
        }
        **/

        public void ShowResults()
        {
            Console.Write("Maths: " + Maths);
            Console.Write("\nPercentage: " + Percentage);
            Console.ReadKey();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Results X;
            X = new Results();
            X.Maths = 75;
            X.Percentage = X.Maths * 100 / 150;
            X.ShowResults();
        }
    }

}
