namespace P03.Vacation
{
    using System;
    class Startup
    {
        public static void Main()
        {
            int peopleCount = int.Parse(Console.ReadLine());
            string peopleType = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double price = 0;

            if (dayOfWeek == "Friday")
            {
                if (peopleType == "Students")
                {
                    if (peopleCount >= 30)
                    {
                        price = 8.45 - (8.45 * 0.15);
                    }
                    else
                    {
                        price = 8.45;
                    }
                }
                else if (peopleType == "Business")
                {
                    if (peopleCount >= 100)
                    {
                        peopleCount -= 10;
                        price = 10.90;
                    }
                    else
                    {
                        price = 10.90;
                    }
                }
                else if (peopleType == "Regular")
                {
                    if (peopleCount >= 10 && peopleCount <= 20)
                    {
                        price = 15 - (15 * 0.05);
                    }
                    else
                    {
                        price = 15;
                    }
                }
            }

            if (dayOfWeek == "Saturday")
            {
                if (peopleType == "Students")
                {
                    if (peopleCount >= 30)
                    {
                        price = 9.80 - (9.80 * 0.15);
                    }
                    else
                    {
                        price = 9.80;
                    }
                }
                else if (peopleType == "Business")
                {
                    if (peopleCount >= 100)
                    {
                        peopleCount -= 10;
                        price = 15.60;
                    }
                    else
                    {
                        price = 15.60;
                    }
                }
                else if (peopleType == "Regular")
                {
                    if (peopleCount >= 10 && peopleCount <= 20)
                    {
                        price = 20 - (20 * 0.05);
                    }
                    else
                    {
                        price = 20;
                    }
                }
            }

            if (dayOfWeek == "Sunday")
            {
                if (peopleType == "Students")
                {
                    if (peopleCount >= 30)
                    {
                        price = 10.46 - (10.46 * 0.15);
                    }
                    else
                    {
                        price = 10.46;
                    }
                }
                else if (peopleType == "Business")
                {
                    if (peopleCount >= 100)
                    {
                        peopleCount -= 10;
                        price = 16;
                    }
                    else
                    {
                        price = 16;
                    }
                }
                else if (peopleType == "Regular")
                {
                    if (peopleCount >= 10 && peopleCount <= 20)
                    {
                        price = 22.50 - (22.50 * 0.05);
                    }
                    else
                    {
                        price = 22.50;
                    }
                }
            }
            double totalPrice = peopleCount * price;
            Console.WriteLine($"Total price: {totalPrice:f2}");
        }
    }
}