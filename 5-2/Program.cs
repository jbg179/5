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
    // Both ISurface.Paint and IControl.Paint call this method.
    public void Paint()
    {
        Console.WriteLine("Paint method in SampleClass");
    }
}
class Program
{
    static void Main(string[] args)
    {
        SampleClass sample = new SampleClass();
        IControl control = sample; // upcasting 
        ISurface surface = sample; // upcasting 
        sample.Paint(); // ((IControl)sample).Paint(); // type casting 
        control.Paint();
        surface.Paint();
    }
}