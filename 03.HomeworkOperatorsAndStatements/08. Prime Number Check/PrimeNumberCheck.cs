using System;
    public class primeNumberCheck
{
    public static void Main()
    {
        bool isPrime = true;
        int number = int.Parse(Console.ReadLine());
        if (number <2)
        {
            isPrime = false;
        }      
        for (int newNumber = 2; newNumber <= Math.Sqrt(number);newNumber++)
        {           
            if (number % newNumber == 0)
            {
                isPrime = (false);
            }
        }
        Console.WriteLine(isPrime);   
    }
}
