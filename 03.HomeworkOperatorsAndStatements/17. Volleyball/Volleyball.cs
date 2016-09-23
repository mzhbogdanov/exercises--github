using System;

    public class VladiTheVolleyballlPlayer
{
        public static void Main()
    {

        string high = (Console.ReadLine());
        int holidays = int.Parse(Console.ReadLine());
        int hometime = int.Parse(Console.ReadLine());
        if (high == "leap")
        {
            int normalWeekends = 48 - hometime;
            double timetovolley = 2d / 3d * holidays + hometime * 1 + normalWeekends * 3d / 4d;
            double ifItsLeap = timetovolley * 0.15;
            Console.WriteLine((int)(timetovolley + ifItsLeap));
        }
        else
        {
            int normalWeekends = 48 - hometime;
            double timetovolley = 2d / 3d * holidays + hometime * 1 + normalWeekends * 3d / 4d;
            Console.WriteLine((int)timetovolley);
        }
    }
}