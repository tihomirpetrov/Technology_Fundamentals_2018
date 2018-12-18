namespace P05.MultiplyBigNumber
{
    using System;
    using System.Text;

    class Program
    {
        public static void Main()
        {
            string bigNumber = Console.ReadLine().TrimStart(new char[] { '0' });
            int singleDigit = int.Parse(Console.ReadLine());
            StringBuilder product = new StringBuilder();
            int save = 0;

            if (bigNumber == "0" || bigNumber.Length < 1 || singleDigit == 0)
            {
                Console.WriteLine("0");
                return;
            }

            for (int i = bigNumber.Length - 1; i >= 0; i--)
            {
                int number = ((int)(bigNumber[i] - 48) * singleDigit) + save;
                save = number / 10;
                number = number % 10;
                product.Insert(0, number);
            }

            if (save > 0)
            {
                product.Insert(0, save);
            }
            Console.WriteLine(product);
        }
    }
}