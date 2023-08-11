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
            double totalArea = 0;
            switch (monument)
            {
                case "Teotihuacan":
                    totalArea += Rect(2500, 1500);
                    totalArea += Triangle(750, 500);
                    totalArea += Circle(375) / 2;
                    totalCost = CalculateTotalCost(totalArea);
                    break;
                case "Taj Mahal":
                    //calculate the area of the complete rectangle, then subtract the area of the four triangles
                    totalArea += Rect(90.5 + 24, 90.5 + 24);
                    totalArea -= 4 * Triangle(24, 24);
                    totalCost = CalculateTotalCost(totalArea);
                    break;
                case "Great Mosque":
                    //calculate the area of the two complete rectangles, then subtract the area of the triangle
                    totalArea += Rect(284, 264);
                    totalArea += Rect(180, 106);
                    totalArea -= Triangle(264, 84);
                    totalCost = CalculateTotalCost(totalArea);
                    break;
            }

            Console.WriteLine($"It will cost {totalCost} pesos to build the {monument}.");
        }

        // in meters
        static double Rect(double length, double width)
        {
            return length * width;
        }

        // in meters
        static double Circle(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        // in meters
        static double Triangle(double bottom, double height)
        {
            return 0.5 * bottom * height;
        }

        // total cost in pesos
        static double CalculateTotalCost(double totalArea)
        {
            return Math.Round(180 * totalArea, 2);
        }
    }
}
