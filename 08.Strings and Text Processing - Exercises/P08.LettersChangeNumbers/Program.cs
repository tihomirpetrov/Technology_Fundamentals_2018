namespace P08.LettersChangeNumbers
{
    using System;
    using System.Linq;

    class Program
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            double sum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                char[] chars = input[i].ToCharArray();
                char firstLetter = chars[0];
                char lastLetter = chars[chars.Length - 1];
                string numberStr = string.Empty;
                double number = 0;
                int divide = 0;
                int multiply = 0;
                int add = 0;
                int substract = 0;

                for (int j = 1; j < chars.Length - 1; j++)
                {
                    numberStr += chars[j];
                }
                number = double.Parse(numberStr);

                if (firstLetter >= 65 && firstLetter <= 90)
                {
                    divide = firstLetter - 64;
                    number = number / divide;
                }
                else if (firstLetter >= 97 && firstLetter <= 122)
                {
                    multiply = firstLetter - 96;
                    number = number * multiply;
                }


                if (lastLetter >= 65 && lastLetter <= 90)
                {
                    substract = lastLetter - 64;
                    number = number - substract;
                }
                else if (lastLetter >= 97 && lastLetter <= 122)
                {
                    add = lastLetter - 96;
                    number = number + add;
                }

                sum += number;

            }
            Console.WriteLine($"{sum:f2}");

        }
    }
}
