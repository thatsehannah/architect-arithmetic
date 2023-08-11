using System;

namespace ArchitectArithmetic
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("What monument would like to work with? ");
            string monument = Console.ReadLine();
            double totalCost = 0;
            switch (monument)
            {
                case "Teotihuacan":
                    totalCost = CalculateTotalCost(1500, 2500, 375, 750, 500);
                    break;
                case "Taj Mahal":
                    totalCost = CalculateTotalCost(rectLength: 90.5, rectHeight: 90.5, triBottom: 24, triHeight: 24);
                    break;
                case "Great Mosque":
                    totalCost = CalculateTotalCost(rectLength: 264, rectHeight: 284, triBottom: 264, triHeight: 84);
                    totalCost += CalculateTotalCost(rectLength: 180, rectHeight: 106);
                    break;
            }

            Console.WriteLine($"It will cost ${totalCost} to build {monument}.");
        }

        static double Rect(double length, double width)
        {
            return length * width;
        }

        static double Circle(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        static double Triangle(double bottom, double height)
        {
            return 0.5 * bottom * height;
        }

        static double CalculateTotalCost(double rectLength = 0, double rectHeight = 0, double radius = 0, double triBottom = 0, double triHeight = 0)
        {
            double totalArea = 0;
            if (rectLength != 0 || rectHeight != 0)
            {
                totalArea += Rect(rectLength, rectHeight);
            }

            if (radius != 0)
            {
                totalArea += Circle(radius);
            }

            if (triBottom != 0 || triHeight != 0)
            {
                totalArea += Triangle(triBottom, triHeight);
            }

            return Math.Round(180 * totalArea, 2);
        }
    }
}
