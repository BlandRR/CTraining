using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp5
{
    class Exam
    {
        private int phy, che, mat;
        private float total, percentage;
        private int counter;

        public int Physics
        {
            get
            {
                return phy;
            }

            set
            {
                if (value >= 0 && value <= 150)
                    phy = value;
                else
                    Console.Write("Invalid Physics Score");
            }
        }

        public int Chemistry
        {
            get
            {
                return che;
            }

            set
            {
                if (value >= 0 && value <= 150)
                    che = value;
                else
                    Console.Write("Invalid Chemistry Score");
            }
        }

        public int Mathimatics
        {
            get
            {
                return mat;
            }

            set
            {
                if (value >= 0 && value <= 150)
                    mat = value;
                else
                    Console.Write("Invalid Mathimatics Score");
            }
        }

        public void Total()
        {
            total = (float)phy + che + mat;
            Console.Write("Scored: " + total + " / Max Marks: 450" + "\n");
        }

        public void Percentage()
        {
            Console.Write(percentage = (float)total * 100 / 450);
        }

        public void Result()
        {
            if (percentage >= 60 && percentage <= 100)
            {
                Console.Write("\n" + "Passed");
                Console.ReadKey();
            }
            else
            {
                Console.Write("\n" + "Failed");
                Console.ReadKey();
            }
        }

        public void ShowResults()
        {
            total = (float)phy + che + mat;
            counter = 0;
            float physcore = (float)phy * 100 / 150;
            float chemscore = (float)che * 100 / 150;
            float mathscore = (float)mat * 100 / 150;

            if (physcore >= 0 && physcore < 60)
            {
                counter++;
            }
            if (chemscore >= 0 && chemscore < 60)
            {
                counter++;
            }
            if (mathscore >= 0 && mathscore < 60)
            {
                counter++;
            }
            if (counter == 0)
            {
                Console.Write("\n" + "Score: " + total + "/450" + "\n");
                percentage = (float)total * 100 / 450;
                Console.Write("Percentage: " + percentage);
                Console.Write("\n" + "Result: Passed");
            }
            if (counter == 1)
            {
                Console.Write("\n" + "Retake the exam"); 
            }
            if (counter == 2)
            {
                Console.Write("\n" + "Repeat the course");
            }
            if (counter == 3)
            {
                Console.Write("\n" + "Go Home");
            }
            Console.ReadKey();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Exam Smith;
            Smith = new Exam();

            Smith.Physics = 100;
            Smith.Chemistry = 91;
            Smith.Mathimatics = 110;
            Smith.ShowResults();

            Console.Write("\n" + "Physics Score: "+ Smith.Physics);
            Console.Write("\n" + "Chemistry Score: " + Smith.Chemistry);
            Console.Write("\n" + "Mathimatics Score: " + Smith. Mathimatics);
            Console.ReadKey();
        }
    }
}
