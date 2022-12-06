using System;
namespace NamespaceTests
{
    class Program
    {
        static void Main(string[] args)
        {
            global::test x = new global::test();
            // var x = new global::test();
            x.SayHello();
            test y = new test();
            y.SayHello();
        }
    }
}
// namespace-less test class
public class test
{
    public void SayHello()
    {
        Console.WriteLine("Hello World!");
    }
}
namespace NamespaceTests
{
    public class test
    {
        public void SayHello()
        {
            Console.WriteLine("Hello Moon....");
        }
    }
}
