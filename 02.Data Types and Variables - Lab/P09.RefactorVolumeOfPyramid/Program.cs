namespace P09.RefactorVolumeOfPyramid
{
    using System;
    class Startup
    {
        public static void Main()
        {
            double dul, sh, V = 0;
            Console.Write("Length: ");
            dul = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            sh = double.Parse(Console.ReadLine());
            Console.Write("Heigth: ");
            V = double.Parse(Console.ReadLine());
            V = (dul + sh + V) / 3;
            Console.WriteLine("Pyramid Volume: {0:F2}", V);

        }
    }
}