namespace P06.ForeignLanguages
{
    using System;
    class Startup
    {
        static void Main()
        {
            string countryName = Console.ReadLine().ToLower();

            if (countryName == "usa" || countryName == "england")
            {
                Console.WriteLine("English");
            }
            else if (countryName == "spain" || countryName == "argentina" || countryName == "mexico")
            {
                Console.WriteLine("Spanish");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}