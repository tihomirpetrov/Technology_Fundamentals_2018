namespace P01.ExtractPersonInformation
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, string> personsNameAge = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string personsName = string.Empty;
                string personsAge = string.Empty;

                for (int j = 0; j < input.Length; j++)
                {
                    if (input[j] == '@')
                    {
                        for (int k = j + 1; k < input.Length; k++)
                        {
                            if (input[k] == '|')
                            {
                                break;
                            }
                            personsName += input[k];
                        }
                    }
                    else if (input[j] == '#')
                    {
                        for (int k = j + 1; k < input.Length; k++)
                        {
                            if (input[k] == '*')
                            {
                                break;
                            }
                            personsAge += input[k];
                        }
                    }
                }

                if (!personsNameAge.ContainsKey(personsName))
                {
                    personsNameAge.Add(personsName, personsAge);
                }
                personsNameAge[personsName] = personsAge;
            }

            foreach (var person in personsNameAge)
            {
                Console.WriteLine($"{person.Key} is {person.Value} years old.");
            }
        }
    }
}