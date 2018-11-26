namespace P04.BackIn30Minutes
{
    using System;
    class Startup
    {
        public static void Main()
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int addMinutes = minutes + 30;

            if (addMinutes <= 59)
            {
                Console.WriteLine($"{hours}:{addMinutes}");
            }
            else if (addMinutes > 59)
            {
                hours = hours + 1;
                addMinutes = addMinutes - 60;
                if (hours > 23)
                {
                    hours = 0;
                }
                if (addMinutes < 10)
                {
                    Console.WriteLine($"{hours}:0{addMinutes}");
                }
                else
                {
                    Console.WriteLine($"{hours}:{addMinutes}");
                }
            }
        }
    }
}