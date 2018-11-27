namespace P09.PadawanEquipment
{
    using System;
    class Startup
    {
        public static void Main()
        {
            double amountOfMoney = double.Parse(Console.ReadLine());
            int countOfStudents = int.Parse(Console.ReadLine());
            double priceSabres = double.Parse(Console.ReadLine());
            double priceRobes = double.Parse(Console.ReadLine());
            double priceBelts = double.Parse(Console.ReadLine());
            double tenPercent = Math.Ceiling(countOfStudents * 1.1);
            double sabresTotal = (priceSabres * tenPercent);
            double robesTotal = priceRobes * countOfStudents;
            int freeBelts = 0;
            for (int i = 1; i <= countOfStudents; i++)
            {
                if (i % 6 == 0)
                {
                    freeBelts++;
                }
            }
            double beltsTotal = priceBelts * (countOfStudents - freeBelts);

            double totalPriceForEquipment = sabresTotal + robesTotal + beltsTotal;
            if (amountOfMoney >= totalPriceForEquipment)
            {
                Console.WriteLine($"The money is enough - it would cost {totalPriceForEquipment:f2}lv.");
            }
            else
            {
                double neededMoney = Math.Abs(totalPriceForEquipment - amountOfMoney);
                Console.WriteLine($"Ivan Cho will need {neededMoney:f2}lv more.");
            }
        }
    }
}