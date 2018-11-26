namespace P01.Train
{
    using System;
    using System.Linq;

    class Startup
    {
        public static void Main()
        {
            int countOfWagons = int.Parse(Console.ReadLine());

            int[] peopleInWagons = new int[countOfWagons];

            for (int i = 0; i < countOfWagons; i++)
            {
                peopleInWagons[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(string.Join(" ", peopleInWagons));
            Console.WriteLine(peopleInWagons.Sum());
        }
    }
}
