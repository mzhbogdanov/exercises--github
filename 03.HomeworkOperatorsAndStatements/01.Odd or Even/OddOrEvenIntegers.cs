using System;
  public class OddOrEvenIntegers
{
    public static void Main()
    {
        int i = int.Parse(Console.ReadLine());
        if (i % 2 == 0)
        {
            Console.WriteLine("is even");
        }
        else
        {
            Console.WriteLine("is odd");
        }
    }
}
