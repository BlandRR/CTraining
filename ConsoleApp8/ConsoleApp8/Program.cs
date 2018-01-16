using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Drawing
    {
        public virtual void Draw()
        {
            Console.Write("Draw Something" + "\n");
        }
    }

    class Line : Drawing
    {
        public override void Draw()
        {
            Console.Write("Draw Line" + "\n");
        }
    }

    class Circle : Drawing
    {
        public override void Draw()
        {
            Console.Write("Draw Circle" + "\n");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Line x = new Line();
            doDrawing(x);

            Circle x1 = new Circle();
            doDrawing(x1);

            Drawing x2 = new Drawing();
            doDrawing(x2);
            Console.ReadKey();
        }
        public static void doDrawing(Drawing d)
        {
            d.Draw();
        }
    }
}
