namespace P02
{
    using System;
    using System.Text;
    class Program
    {
        static void Main()
        {
            string firstInput = Console.ReadLine();
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < firstInput.Length; i++)
            {
                if (!(firstInput[i] >= 100 && firstInput[i] <= 122 || firstInput[i] == ',' || firstInput[i] == '|' || firstInput[i] == '#'))
                {
                    Console.WriteLine("This is not the book you are looking for.");
                    return;
                }
            }

            for (int i = 0; i < firstInput.Length; i++)
            {
                sb.Append((char)(firstInput[i] - 3));
            }

            string[] secondInput = Console.ReadLine().Split();
            string forReplacement = secondInput[0];
            string replacement = secondInput[1];

            for (int i = 0; i < sb.Length; i++)
            {
                sb = sb.Replace(forReplacement, replacement);
            }
            //string text = sb.ToString();
            //sb.Clear();
            //string[] temp = text.Split(forReplacement);

            //for (int i = 0; i < temp.Length - 1; i++)
            //{
            //    sb.Append(temp[i]);
            //    sb.Append(replacement);
            //}
            //sb.Append(temp[temp.Length - 1]);

            Console.WriteLine(sb);
        }
    }
}