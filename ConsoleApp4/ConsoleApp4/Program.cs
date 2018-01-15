using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Exam
    {
        private int phy, che, mat;
        private float total, percentage;
        private int counter;

        public void Physics(int A)
        {
            if (A >= 0 && A <= 150)
                phy = A;
            else
                Console.Write("Invalid Physics Mark" + "\n");
        }

        public void Chemistry(int A)
        {
            if (A >= 0 && A <= 150)
                che = A;
            else
                Console.Write("Invalid Chemistry Mark" + "\n");
        }

        public void Maths(int A)
        {
            if (A >= 0 && A <= 150)
                mat = A;
            else
                Console.Write("Invalid Maths Mark" + "\n");
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


        public void Show()
        {
            total = (float)phy + che + mat;

            Console.Write("\n" + "Score: " + total + "/450" + "\n");
            percentage = (float)total * 100 / 450;
            Console.Write("Percentage: " + percentage);
            if (percentage >= 60 && percentage <= 100)
            {
                Console.Write("\n" + "Passed" + "\n");
                Console.ReadKey();
            }
            else
            {
                Console.Write("\n" + "Failed" + "\n");
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
                Console.ReadKey(); 
            }
            if (counter == 1)
            {
                Console.Write("\n" + "Retake the exam");
                Console.ReadKey();
            }
            if (counter == 2)
            {
                Console.Write("\n" + "Repeat the course");
                Console.ReadKey();
            }
            if (counter == 3)
            {
                Console.Write("\n" + "Go Home");
                Console.ReadKey();
            }
        }
    }




    class Program
    {
        static void Main(string[] args)
        {
            Exam Smith, Harry, Bob, Mary;

            Smith = new Exam();
            Harry = new Exam();
            Bob = new Exam();
            Mary = new Exam();

            Smith.Physics(100);
            Smith.Chemistry(150);
            Smith.Maths(150);
            Smith.ShowResults();

            Harry.Physics(30);
            Harry.Chemistry(60);
            Harry.Maths(50);
            Harry.ShowResults();

            Bob.Physics(25);
            Bob.Chemistry(100);
            Bob.Maths(100);
            Bob.ShowResults();

            Mary.Physics(100);
            Mary.Chemistry(80);
            Mary.Maths(80);
            Mary.ShowResults();
        }
    }
}
