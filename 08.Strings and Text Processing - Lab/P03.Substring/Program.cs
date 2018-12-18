namespace P03.Substring
{
    using System;

    class Program
    {
        public static void Main()
        {
            string firstInput = Console.ReadLine().ToLower();
            string secondInput = Console.ReadLine().ToLower();

            int index = secondInput.IndexOf(firstInput);

            while (index != -1)
            {
                secondInput = secondInput.Remove(index, firstInput.Length);
                index = secondInput.IndexOf(firstInput);
            }
            Console.WriteLine(secondInput);
        }
    }
}