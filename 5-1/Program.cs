using System;
namespace Polymorphism_class_2
{
    class Shape
    {
        virtual public void Draw()
        {
        }
    }
    class Circle : Shape
    {
        override public void Draw()
        {
            Console.WriteLine("I am Circle");
        }
        public void CalArea()
        {
            Console.WriteLine("PI * R * R");
        }
    }
    class Rectangle : Shape
    {
        override public void Draw()
        {
            Console.WriteLine("I am Rectangle");
        }
        public void CalArea()
        {
            Console.WriteLine("W * H");
        }
    }
    class Triangle : Shape
    {
        override public void Draw()
        {
            Console.WriteLine("I am Triangle");
        }
        public void CalArea()
        {
            Console.WriteLine("W * H*0.5");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Paint(new Circle());
            Paint(new Rectangle());
            Paint(new Triangle());
        }
        static void Paint(Shape shape)
        {
            // shape.Draw();
            Circle cir = shape as Circle; // if casting is not possible, return null
            Rectangle rect = shape as Rectangle;
            Triangle tri = shape as Triangle;
            if (cir != null)
            {
                // cir.Draw(); // OK
                shape.Draw();
                cir.CalArea();
                // shape.CalArea(); // NOT-OK
            }
            else if (rect != null)
            {
                // rect.Draw(); //OK
                shape.Draw();
                rect.CalArea();
            }
            else if (tri != null)
            {
                tri.Draw(); // OK
                            // shape.Draw(); // OK
                tri.CalArea();
                // shape.CalArea(); // NOT-OK
            }
        }
    }
}