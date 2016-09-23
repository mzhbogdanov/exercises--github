using System;
    public class TrapezoidArea
{
        public static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double h = double.Parse(Console.ReadLine());
        double area = (a + b) / 2 * h;
        Console.WriteLine("The areas of trapezoid is :{0} ", area);
    }
}
