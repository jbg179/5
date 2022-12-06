using System;
namespace Polymorphism_2
{
    interface IShape
    {
        void Draw();
    }
    public class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("I am Circle");
        }
        public void CalArea()
        {
            Console.WriteLine("PI * R * R");
        }
    }
    public class Rectangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("I am Rectangle");
        }
        public void CalArea()
        {
            Console.WriteLine("W * H");
        }
    }
    public class Line : IShape
    {
        public void Draw()
        {
            Console.WriteLine("I am Line");
        }

    }
    class Program
    {
        static void Main(string[] args
        )
        {
            Paint(new Circle());
            Paint(new Rectangle());
            Paint(new Line());
        }
        static void Paint(IShape shape)
        {
            Circle cir = shape as Circle; // if casting is not possible, return null
            Rectangle rect = shape as Rectangle;
            Line lin = shape as Line;
            if (cir != null)
            {
                cir.Draw();
                cir.CalArea();
            }
            else if (rect != null)
            {
                rect.Draw();
                rect.CalArea();
            }
            else if (lin != null)
            {
                lin.Draw();
                lin.CalArea();
            }
        }
    }
}