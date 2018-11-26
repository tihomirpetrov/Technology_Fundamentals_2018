namespace P06.CardsGame
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Startup
    {
        static void Main()
        {
            List<int> firstHand = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondHand = Console.ReadLine().Split().Select(int.Parse).ToList();
            int bigHand = int.MinValue;
            int smallHand = int.MinValue;

            while (true)
            {
                if (firstHand.Count <= 0 || secondHand.Count <= 0)
                {
                    break;
                }

                else
                {
                    if (firstHand[0] > secondHand[0])
                    {
                        bigHand = firstHand[0];
                        smallHand = secondHand[0];
                        firstHand.Add(firstHand[0]);
                        firstHand.Add(secondHand[0]);
                        firstHand.RemoveAt(0);
                        secondHand.RemoveAt(0);
                    }
                    else if (firstHand[0] < secondHand[0])
                    {
                        bigHand = secondHand[0];
                        smallHand = firstHand[0];
                        secondHand.Add(secondHand[0]);
                        secondHand.Add(firstHand[0]);
                        secondHand.RemoveAt(0);
                        firstHand.RemoveAt(0);
                    }
                    else if (firstHand[0] == secondHand[0])
                    {
                        firstHand.Remove(firstHand[0]);
                        secondHand.Remove(secondHand[0]);
                    }
                }

            }

            if (firstHand.Count > secondHand.Count)
            {
                Console.WriteLine($"First player wins! Sum: {firstHand.Sum()}");
            }
            else
            {
                Console.WriteLine($"Second player wins! Sum: {secondHand.Sum()}");
            }

        }
    }
}
