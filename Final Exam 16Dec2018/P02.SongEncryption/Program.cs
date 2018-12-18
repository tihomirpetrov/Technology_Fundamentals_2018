namespace P02.FinalExam
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;

    class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            string pattern = @"^([A-Z][a-z\s']+):([A-Z\s]+)$";

            while (input != "end")
            {
                Match match = Regex.Match(input, pattern);

                if (!match.Success)
                {
                    Console.WriteLine("Invalid input!");
                }

                else
                {
                    string artistEncrypt = match.Groups[1].Value;
                    int key = artistEncrypt.Length;
                    string songEncrypt = match.Groups[2].Value;
                    StringBuilder sbencrypt = new StringBuilder();
                    for (int i = 0; i < artistEncrypt.Length; i++)
                    {
                        if (artistEncrypt[i] == ' ' || artistEncrypt[i] == '\t')
                        {
                            sbencrypt.Append(artistEncrypt[i]);
                        }
                        else
                        {
                            if (i == 0)
                            {
                                if (artistEncrypt[i] + key > 90)
                                {
                                    sbencrypt.Append((char)(artistEncrypt[i] + key - 26));
                                }
                                else
                                {
                                    sbencrypt.Append((char)(artistEncrypt[i] + key));
                                }
                            }
                            else
                            {
                                if (artistEncrypt[i] == '\'')
                                {
                                    sbencrypt.Append(artistEncrypt[i]);
                                }
                                else
                                {
                                    if (artistEncrypt[i] + key > 122)
                                    {
                                        sbencrypt.Append((char)(artistEncrypt[i] + key - 26));
                                    }
                                    else
                                    {
                                        sbencrypt.Append((char)(artistEncrypt[i] + key));
                                    }
                                }
                            }
                        }
                    }
                    sbencrypt.Append("@");
                    for (int i = 0; i < songEncrypt.Length; i++)
                    {
                        if (songEncrypt[i] == ' ' || songEncrypt[i] == '\t')
                        {
                            sbencrypt.Append(songEncrypt[i]);
                        }
                        else
                        {
                            if (songEncrypt[i] + key > 90)
                            {
                                sbencrypt.Append((char)(songEncrypt[i] + key - 26));
                            }
                            else
                            {
                                sbencrypt.Append((char)(songEncrypt[i] + key));
                            }
                        }
                    }

                    Console.WriteLine($"Successful encryption: {sbencrypt}");
                    sbencrypt.Clear();
                }

                input = Console.ReadLine();
            }
        }
    }
}