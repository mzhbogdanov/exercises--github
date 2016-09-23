using System;
    public class FourDigitNumber
{
        public static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        int a = (num / 1000) % 10;
        int b = (num / 100) % 10;
        int c = (num / 10) % 10;
        int d = num % 10;
        int sum = a + b + c + d;
        Console.WriteLine("Sum of the digits = {0}", sum);
        Console.WriteLine("Reversed = " + d + "" + c + "" + b + "" + a);
        Console.WriteLine("Put the last digit in front = " + d + "" + a + "" + b + "" + c);
        Console.WriteLine("Exchange third and fourth digit = " + a + "" + c + "" + b + "" + d);
    }
}

