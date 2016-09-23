using System;
    public class pointInCircleAndRectangle
{
        public static void Main()
    {
        double radius = 1.5;
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        bool circle = radius * radius >= (x - 1) * (x - 1) + (y - 1) * (y - 1);
        bool isInRectangle = (x >= -1) && (x <= 5) && (y >= -1) && (y <= 1);
        Console.WriteLine(circle && !isInRectangle ? "yes" : "no");
    }
}
