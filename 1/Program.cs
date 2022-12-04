using System;
namespace overriding_console_1
{
    class Parent
    {
        // public virtual int variable = 273; // // 오류 : override 사용 불가
        public int variable = 273;
        public virtual void Method()
        {
            Console.WriteLine("부모의 메소드");
            Console.WriteLine("variable ={0}", variable);
        }
    }
    class Child : Parent
    {
        // public override string variable = "overriding"; // 오류 : override 사용 불가
        public new string variable = "overriding"; // default : new
        public override void Method()
        {
            Console.WriteLine("자식의 메소드");
            base.Method();
            Console.WriteLine("base: variable ={0}", base.variable);
            Console.WriteLine("variable ={0}", variable);
        }
        static void Main(string[] args)
        {
            Child child = new Child();
            child.Method();
            ((Parent)child).Method(); // parent가 아닌 child의 method()가 호출됨
        }
    }
}
