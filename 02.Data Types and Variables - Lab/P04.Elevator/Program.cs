namespace P04.Elevator
{
    using System;
    class Startup
    {
        public static void Main()
        {
            int peopleCount = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            int counter = 0;
            for (int i = 0; i < peopleCount; i++)
            {
                if (i % capacity == 0)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}