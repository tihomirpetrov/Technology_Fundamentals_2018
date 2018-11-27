namespace P03.TakeSkipRope
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Startup
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            List<int> numbers = new List<int>();
            List<char> letters = new List<char>();
            int number = 0;
            bool isNotNum = int.TryParse(input, out number);

            for (int i = 0; i < input.Length; i++)
            {
                if (!isNotNum)
                {
                    letters.Add(input[i]);
                }
            }

            for (int i = 0; i < letters.Count; i++)
            {
                if (letters[i] >= 48 && letters[i] <= 57)
                {
                    double temp = Char.GetNumericValue(letters[i]);
                    int result = Convert.ToInt32(temp);
                    numbers.Add(result);
                    letters.RemoveAt(i);
                    i = -1;
                }
            }

            List<int> take = new List<int>();
            List<int> skip = new List<int>();


            for (int i = 0; i < numbers.Count; i++)
            {
                if (i % 2 == 0)
                {
                    take.Add(numbers[i]);
                }
                else
                {
                    skip.Add(numbers[i]);
                }
            }

            string word = string.Empty;
            int count = skip.Count;

            for (int j = 0; j < count; j++)
            {
                int takeInt = take[0];
                if (takeInt > letters.Count)
                {
                    takeInt = letters.Count;
                }
                for (int i = 0; i < takeInt; i++)
                {
                    word += letters[i];
                }
                letters.RemoveRange(0, takeInt);
                take.RemoveAt(0);
                letters.RemoveRange(0, skip[0]);
                skip.RemoveAt(0);
            }

            Console.WriteLine(word);
        }
    }
}