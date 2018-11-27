namespace P05.DrumSet
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Startup
    {
        public static void Main()
        {
            double savingsGabsy = double.Parse(Console.ReadLine());
            List<int> initialQualityOfDrums = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> drumsAfterPractice = new List<int>();

            foreach (var drum in initialQualityOfDrums)
            {
                drumsAfterPractice.Add(drum);
            }
            string command = Console.ReadLine();
            double price = 0;

            while (command != "Hit it again, Gabsy!")
            {
                int hitPower = int.Parse(command);

                for (int i = 0; i < initialQualityOfDrums.Count; i++)
                {
                    drumsAfterPractice[i] -= hitPower;
                    if (drumsAfterPractice[i] < 0)
                    {
                        drumsAfterPractice[i] = 0;
                    }
                    if (drumsAfterPractice[i] == 0)
                    {
                        for (int j = 0; j < drumsAfterPractice.Count; j++)
                        {
                            if (drumsAfterPractice[j] == 0)
                            {
                                price = initialQualityOfDrums[j] * 3;
                                if (price <= savingsGabsy)
                                {
                                    drumsAfterPractice[j] = initialQualityOfDrums[j];
                                    savingsGabsy -= price;
                                }
                                else
                                {
                                    drumsAfterPractice.RemoveAt(j);
                                    initialQualityOfDrums.RemoveAt(j);
                                    i--;
                                }
                            }
                        }
                    }
                }
                command = Console.ReadLine();
            }

            //drumsAfterPractice = drumsAfterPractice.Where(x => x != 0).ToList();
            Console.WriteLine(string.Join(" ", drumsAfterPractice));
            Console.WriteLine($"Gabsy has {savingsGabsy:f2}lv.");

        }
    }
}