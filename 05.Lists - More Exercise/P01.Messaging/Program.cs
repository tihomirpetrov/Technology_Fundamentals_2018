namespace Messaging
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class Startup
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            char[] message = Console.ReadLine().ToCharArray();
            List<char> elements = new List<char>();
            for (int i = 0; i < message.Length; i++)
            {
                elements.Add(message[i]);
            }
            List<int> sumOfDigits = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                int number = numbers[i];
                int sum = 0;
                while (number > 0)
                {
                    int lastDigit = number % 10;
                    sum += lastDigit;
                    number = number / 10;
                }
                sumOfDigits.Add(sum);

            }

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < sumOfDigits.Count; i++)
            {
                int num = sumOfDigits[i];
                num %= elements.Count;

                sb.Append(elements[num]);
                elements.RemoveAt(num);
            }
            Console.WriteLine(sb);
        }
    }
}