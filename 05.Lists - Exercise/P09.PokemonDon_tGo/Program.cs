namespace P09.PokemonDon_tGo
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Startup
    {
        public static void Main()
        {
            List<int> sequence = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> indexes = Console.ReadLine().Split().Select(int.Parse).ToList();
            int sum = 0;
            while (true)
            {
                int index = indexes[0];
                int number = 0;
                if (index >= sequence.Count)
                {
                    index = sequence.Count - 1;
                    number = sequence[index];
                    sum += number;
                    sequence.RemoveAt(sequence.Count - 1);
                    sequence.Add(sequence[0]);
                }

                else if (index < 0)
                {
                    index = 0;
                    number = sequence[index];
                    sum += number;
                    sequence.RemoveAt(0);
                    sequence.Insert(0, sequence[sequence.Count - 1]);
                }
                else
                {
                    number = sequence[index];
                    sum += number;
                    sequence.RemoveAt(index);
                }

                for (int i = 0; i < sequence.Count; i++)
                {
                    if (sequence[i] <= number)
                    {
                        sequence[i] += number;
                    }
                    else if (sequence[i] > number)
                    {
                        sequence[i] -= number;
                    }
                }

                if (sequence.Count <= 0)
                {
                    break;
                }

                indexes = Console.ReadLine().Split().Select(int.Parse).ToList();
            }
            Console.WriteLine(sum);
        }
    }
}