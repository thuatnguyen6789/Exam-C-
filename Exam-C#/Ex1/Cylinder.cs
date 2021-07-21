using System;

namespace GeometryExample
{
    public class Cylinder
    {
        private static string a = "";
        private static double BaseArea;
        private static double Height;
        private static double LateralArea;
        private static double Radius;
        private static double TotalArea;
        private static double Volume;

        public static void Process()
        {
            //Read Radius
            Console.WriteLine("Enter the dimensions of the cylinder");
            Console.Write("Radius:");
            a = Console.ReadLine();
            Radius = Convert.ToDouble(a);

            //Read Height
            Console.Write("Height:");
            a = Console.ReadLine();
            Height = Convert.ToDouble(a);

            BaseArea = Radius * Radius * Math.PI;
            LateralArea = 2 * Math.PI * Radius * Height;
            TotalArea = 2 * Math.PI * Radius * (Height + Radius);
            Volume = Math.PI * Radius * Radius * Height;
            Console.WriteLine();
        }

        public static void Result()
        {
            var Message = "Radius: " + string.Format("{0:0.##}", Radius) + ", " + "Height:" +
                          string.Format("{0:0.##}", Height);

            var Result = "Base: " + string.Format("{0:0.##}", BaseArea) + " | "
                         + "Lateral: " + string.Format("{0:0.##}", LateralArea) + " | "
                         + "Total: " + string.Format("{0:0.##}", TotalArea) + " | "
                         + "Volume: " + string.Format("{0:0.##}", Volume);
            Console.WriteLine("Cylinder Characteristics");
            Console.WriteLine(Message);
            Console.WriteLine(Result);
        }
    }
}