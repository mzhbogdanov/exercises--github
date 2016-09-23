using System;

public class WeightOnTheMoon
{
    public static void Main()
    {
        double weight = double.Parse(Console.ReadLine());
        double weightOnMoon = (weight * 17) / 100;
        Console.WriteLine(weightOnMoon);

    }
}
