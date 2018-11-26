namespace P09.PalindromeIntegers
{
    using System;
    using System.Linq;

    class Program
    {
        public static void Main()
        {
            string command = Console.ReadLine();
            while (command != "END")
            {
                string number = Palindrome(command) ? "true" : "false";
                Console.WriteLine(number);
                //if (isPalindrome)
                //{
                //   Console.WriteLine("true");
                //}
                //else
                //{
                //    Console.WriteLine("false");
                //}
                command = Console.ReadLine();
            }
        }
        public static bool Palindrome(string command)
        {
            bool isPalindrome = true;
            for (int i = 0; i < command.Length / 2; i++)
            {
                if (command[i] != command[command.Length - 1 - i])
                {
                    isPalindrome = false;
                }
            }

            return isPalindrome;
        }
    }
}