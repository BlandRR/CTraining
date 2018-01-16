using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{

    abstract class mammal
    {
        public abstract void size();
        public abstract void lifeexpectancy();
    }


    class human : mammal
    {
        public override void size()
        {
            Console.Write("Average Size =  5.8ft" + "\n");
        }

        public override void lifeexpectancy()
        {
            Console.Write("Average LifeExpectancy = 80 years" + "\n");
        }

    }


    class whale : mammal
    {
        public override void size()
        {
            Console.Write("Average Size = Very Big" + "\n");
        }

        public override void lifeexpectancy()
        {
            Console.Write("Average LifeExpectancy = Very long" + "\n");
        }
    }




    class Program
    {
        static void Main(string[] args)
        {
            human h = new human();
            Console.Write("Human" + "\n");
            getsize(h);
            getage(h);


            whale w = new whale();
            Console.Write("\n" + "Whale" + "\n");
            getsize(w);
            getage(w);
            Console.ReadKey();
            
        }

        public static void getsize(mammal d)
        {
            d.size();
        }

        public static void getage(mammal d)
        {
            d.lifeexpectancy();
        }
    }
}
