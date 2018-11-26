namespace P02.VowelsCount
{
    using System;
    class Program
    {
        public static void Main()
        {
            string word = Console.ReadLine().ToLower();
            int counter = 0;
            VowelsCount(word, counter);
        }

        private static int VowelsCount(string word, int counter)
        {

            for (int i = 0; i < word.Length; i++)
            {
                char character = word[i]; ;

                switch (character)
                {
                    case 'a':
                        counter++;
                        break;
                    case 'e':
                        counter++;
                        break;
                    case 'i':
                        counter++;
                        break;
                    case 'o':
                        counter++;
                        break;
                    case 'u':
                        counter++;
                        break;
                }
            }
            Console.WriteLine(counter);
            return counter;
        }
    }
}