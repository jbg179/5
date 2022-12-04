using System;
public interface IControl
{
    void Paint();
}
public interface ISurface
{
    void Paint();
}
public class SampleClass : IControl, ISurface
{
    void IControl.Paint()
    {
        System.Console.WriteLine("IControl.Paint");
    }
    void ISurface.Paint()
    {
        System.Console.WriteLine("ISurface.Paint");
    }
}
class Program
{
    static void Main(string[] args)
    {
        SampleClass sample = new SampleClass();
        IControl control = sample; // upcasting 
        ISurface surface = sample; // upcasting 
                                   //sample.Paint(); // Compiler error.
        control.Paint(); // Calls IControl.Paint on SampleClass.
        surface.Paint(); // Calls ISurface.Paint on SampleClass.
        ((IControl)sample).Paint(); // type casting 
        ((ISurface)sample).Paint(); // type casting 
    }
}
