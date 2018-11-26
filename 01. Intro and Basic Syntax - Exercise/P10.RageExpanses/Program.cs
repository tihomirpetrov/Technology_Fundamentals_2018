namespace P10.Rage_Expenses
{
    using System;

    class Startup
    {
        public static void Main()
        {
            int lostGameCount = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());
            int counterHeadset = 0;
            int counterMouse = 0;
            int counterKeyboard = 0;
            int counterDisplay = 0;

            for (int i = 1; i <= lostGameCount; i++)
            {
                if (i % 2 == 0)
                {
                    counterHeadset++;
                }
                if (i % 3 == 0)
                {
                    counterMouse++;
                }
                if (i % 2 == 0 && i % 3 == 0)
                {
                    counterKeyboard++;
                    if (counterKeyboard % 2 == 0)
                    {
                        counterDisplay++;
                    }
                }
            }
            double totalHeadset = headsetPrice * counterHeadset;
            double totalMouse = mousePrice * counterMouse;
            double totalKeyboard = keyboardPrice * counterKeyboard;
            double totalDisplay = displayPrice * counterDisplay;
            double totalexpanses = totalHeadset + totalMouse + totalKeyboard + totalDisplay;
            Console.WriteLine($"Rage expenses: {totalexpanses:f2} lv.");
        }
    }
}