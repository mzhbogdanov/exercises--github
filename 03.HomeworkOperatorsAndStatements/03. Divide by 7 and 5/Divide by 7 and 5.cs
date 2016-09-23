using System;

public class DivideBySevenOrFive
{
    public static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        bool result = (number % 5 == 0 && number % 7 == 0 && number != 0) ? true : false;
        Console.WriteLine(result);
    }
}

