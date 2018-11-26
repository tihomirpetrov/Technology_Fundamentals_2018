namespace P08.Snowballs
{
    using System;
    class Startup
    {
        public static void Main()
        {
            int numberOfSnowBalls = int.Parse(Console.ReadLine());
            int snowballSnow = 0;
            int snowballTime = 0;
            int snowballQuality = 0;
            //int snowballValue = 0;
            double highestSnow = double.MinValue;
            double highestTime = double.MinValue;
            double highestQuality = double.MinValue;
            double highestValue = double.MinValue;
            for (int i = 1; i <= numberOfSnowBalls; i++)
            {
                snowballSnow = int.Parse(Console.ReadLine());
                snowballTime = int.Parse(Console.ReadLine());
                snowballQuality = int.Parse(Console.ReadLine());
                double snowballValue = Math.Pow((snowballSnow / snowballTime), snowballQuality);
                if (snowballValue > highestValue)
                {
                    highestValue = snowballValue;
                    highestSnow = snowballSnow;
                    highestTime = snowballTime;
                    highestQuality = snowballQuality;
                }
            }
            Console.WriteLine($"{highestSnow} : {highestTime} = {highestValue} ({highestQuality})");
        }
    }
}