using System;
    public class showMePositionsOfBits
{
        public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        int one = 1;
        int mask = one << p;
        //show me the the bit position before replace by val=v
        Console.WriteLine((n & mask) != 0 ? 1 : 0);
        string NumberBinaryString = Convert.ToString(n, 2);
        //binary representation of n before 
        Console.WriteLine(NumberBinaryString);
        // value of v must be 0 or 1
        int v = int.Parse(Console.ReadLine());
        if (v == 0)
        {
            n = n & (~(1 << p));
        }
        else
        {
            n = n | (1 << p);
        }
        Console.WriteLine(((n & mask) != 0 ? 1 : 0));
        string NumberBinaryString2 = Convert.ToString(n, 2);
        Console.WriteLine(NumberBinaryString2);
        //on this line convert the new number from binnary to decimal
        string newNumber = Convert.ToString(n, 10);
        Console.WriteLine(newNumber);
    }
}
