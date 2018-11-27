namespace P01.AdvertisementMessage
{
    using System;

    class Program
    {
        public static void Main()
        {
            var random = new Random();
            string[] phrases = new string[] { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product." };
            string[] events = new string[] { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
            string[] authors = new string[] { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            string[] cities = new string[] { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                int index1 = random.Next(0, phrases.Length);
                Console.Write($"{phrases[index1]} ");
                int index2 = random.Next(0, events.Length);
                Console.Write($"{events[index2]} ");
                int index3 = random.Next(0, authors.Length);
                Console.Write($"{authors[index3]} - ");
                int index4 = random.Next(0, cities.Length);
                Console.WriteLine(cities[index4]);
            }
        }
    }
}