using System;

    public class RectanglesPerimetarAndArea
{
    public static void Main()
    {
        double height = double.Parse(Console.ReadLine());
        double width = double.Parse(Console.ReadLine());
        Console.WriteLine("The rectangle’s perimeter is " + 2 * (height + width) + "\n" + "And Area is " + (height * width));

    }
}
