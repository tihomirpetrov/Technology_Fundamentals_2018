namespace P09.RageQuit
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class StartUp
    {
        public static void Main()
        {
            string input = Console.ReadLine().ToUpper();
            List<string> textWithSeparateDigits = new List<string>();

            StringBuilder sb = new StringBuilder();

            foreach (var item in input)
            {
                if ((int)item < 48 || (int)item > 57)
                {
                    sb.Append(item);
                }
                else
                {
                    if (sb.Length > 0)
                    {
                        textWithSeparateDigits.Add(sb.ToString());
                        sb.Clear();
                    }
                    textWithSeparateDigits.Add(item.ToString());
                }
            }

            List<string> text = new List<string>();
            foreach (var item in textWithSeparateDigits)
            {
                if (item.Length == 1)
                {
                    if (item == "0" || item == "1" || item == "2" || item == "3" || item == "4" || item == "5" || item == "6" || item == "7" || item == "8" || item == "9")
                    {
                        sb.Append(item);
                    }
                    else
                    {
                        if (sb.Length > 0)
                        {
                            text.Add(sb.ToString());
                        }
                        sb.Clear();
                        text.Add(item.ToString());
                    }
                }
                else
                {
                    if (sb.Length > 0)
                    {
                        text.Add(sb.ToString());
                    }
                    sb.Clear();
                    text.Add(item);
                }
            }
            text.Add(sb.ToString());
            sb.Clear();

            for (int i = 0; i < text.Count; i += 2)
            {
                string word = text[i];
                int count = int.Parse(text[i + 1]);

                for (int j = 0; j < count; j++)
                {
                    sb.Append(word);
                }
            }
            string message = sb.ToString();

            List<char> symbols = new List<char>();
            foreach (var item in message)
            {
                if (!(symbols.Contains(item)))
                {
                    symbols.Add(item);
                }
            }
            Console.WriteLine($"Unique symbols used: {symbols.Count}");
            Console.WriteLine(message);
        }
    }
}