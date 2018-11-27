namespace P02.Passed
{
    using System;

    class Program
    {
        public static void Main()
        {
            double grade = double.Parse(Console.ReadLine());
            if (grade >= 3)
            {
                Console.WriteLine("Passed!");
            }
        }
    }
}