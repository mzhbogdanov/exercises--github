using System;

    public class ThirdDigitis7
{
     public static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        {
            bool check = ((num / 100) % 10 == 7);
            Console.WriteLine("Third digit is 7: {0}", check);
        }
        try
         {
         }
        catch
        {
            Console.WriteLine("Invalid input format.");
        }
    }
}
