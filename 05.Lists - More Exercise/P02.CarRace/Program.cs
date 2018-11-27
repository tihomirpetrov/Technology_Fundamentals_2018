namespace P02.CarRace
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Startup
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            double leftSideCar = 0;
            double rightSideCar = 0;

            for (int i = 0; i < numbers.Count / 2; i++)
            {
                if (numbers[i] == 0)
                {
                    leftSideCar = leftSideCar * 0.8;
                }
                else
                {
                    leftSideCar += numbers[i];
                }

                if (numbers[numbers.Count - 1 - i] == 0)
                {
                    rightSideCar = rightSideCar * 0.8;
                }
                else
                {
                    rightSideCar += numbers[numbers.Count - 1 - i];
                }
            }

            if (leftSideCar < rightSideCar)
            {
                Console.WriteLine($"The winner is left with total time: {leftSideCar}");
            }
            else
            {
                Console.WriteLine($"The winner is right with total time: {rightSideCar}");
            }
        }
    }
}