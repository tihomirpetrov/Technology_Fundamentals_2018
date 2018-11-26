namespace P10.LadyBugs
{
    using System;
    using System.Linq;

    class Startup
    {
        public static void Main()
        {
            int sizeOfField = int.Parse(Console.ReadLine());
            int[] indexesWithBugs = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] cells = new int[sizeOfField];

            if (sizeOfField <= 0)
            {
                return;
            }

            for (int i = 0; i < indexesWithBugs.Length; i++)
            {
                if (indexesWithBugs[i] >= 0 && indexesWithBugs[i] < cells.Length)
                {
                    cells[indexesWithBugs[i]] = 1;
                }
            }


            string command = Console.ReadLine();
            while (command != "end")
            {
                string[] ladybugFly = command.Split().ToArray();
                int ladybugIndex = int.Parse(ladybugFly[0]);
                string direction = ladybugFly[1];
                int flyLength = int.Parse(ladybugFly[2]);

                if (ladybugIndex < sizeOfField && ladybugIndex >= 0)
                {
                    if (cells[ladybugIndex] == 1)
                    {
                        cells[ladybugIndex] = 0;
                        if (direction == "right")
                        {
                            if (ladybugIndex + flyLength < cells.Length && ladybugIndex + flyLength >= 0)
                            {
                                for (int i = ladybugIndex + flyLength; i < int.MaxValue; i += flyLength)
                                {
                                    if (i < 0 || i >= cells.Length)
                                    {
                                        break;
                                    }
                                    else if (cells[i] == 0)
                                    {
                                        if (i >= 0 && i < cells.Length)
                                        {
                                            cells[i] = 1;
                                            break;
                                        }
                                    }
                                }
                            }
                        }

                        if (direction == "left")
                        {
                            if (ladybugIndex - flyLength < cells.Length && ladybugIndex - flyLength >= 0)
                            {
                                for (int i = ladybugIndex - flyLength; i < int.MaxValue; i -= flyLength)
                                {
                                    if (i < 0 || i >= cells.Length)
                                    {
                                        break;
                                    }
                                    else if (cells[i] == 0)
                                    {
                                        if (i >= 0 && i < cells.Length)
                                        {
                                            cells[i] = 1;
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", cells));
        }
    }
}