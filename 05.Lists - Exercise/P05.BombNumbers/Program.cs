namespace P05.BombNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Startup
    {
        static void Main()
        {
            List<int> sequence = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> bombNumber = Console.ReadLine().Split().Select(int.Parse).ToList();
            int bomb = bombNumber[0];
            int power = bombNumber[1];
            int startDetonate = 0;
            int endDetonate = 0;

            for (int i = 0; i < sequence.Count; i++)
            {
                if (sequence[i] == bomb)
                {
                    startDetonate = i - power;
                    endDetonate = i + power;

                    if (startDetonate < 0)
                    {
                        startDetonate = 0;
                    }

                    if (endDetonate > sequence.Count - 1)
                    {
                        endDetonate = sequence.Count - 1;
                    }

                    if (startDetonate > sequence.Count - 1 || endDetonate < 0)
                    {
                        continue;
                    }
                    //sequence.Remove(sequence[i]);                      
                    sequence.RemoveRange(startDetonate, endDetonate - startDetonate + 1);
                    i = startDetonate - 1;
                }
            }
            Console.WriteLine(string.Join(" ", sequence.Sum()));
        }
    }
}
