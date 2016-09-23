using System;
public class CircleAndrectangle
{
    public static void Main()
    {
        double radius = 2;
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        double z = Math.Sqrt((x * x) + (y * y));
        if (z <= radius)
        {
            Console.WriteLine(true);
        }
        else
        {
            Console.WriteLine(false);
        }

    }
}
