using System;
public class ExtractBit3
{
        public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int p = 3;
        int positionToR = n >> p;
        int bit = positionToR & 1;
        Console.WriteLine(bit);
    }
}
