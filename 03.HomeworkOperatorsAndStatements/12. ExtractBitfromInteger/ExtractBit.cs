using System;
    public class ExtractBitfromInteger
{
        public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        int one = 1;
        int mask = one << p;
        Console.WriteLine((n & mask) != 0 ? 1 : 0);
    }
}
