using System;
namespace Polymorphism_1
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
    }
    public class Rectangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("I am Rectangle");
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
        static void Main(string[] args)
        {
            Paint(new Circle());
            Paint(new Rectangle());
            Paint(new Line());
        }
        static void Paint(IShape shape)
        {
            shape.Draw();
        }
    }
}