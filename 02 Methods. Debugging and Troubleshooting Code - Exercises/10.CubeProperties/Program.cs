using System;

namespace _10.CubeProperties
{
    class Program
    {
        public static void Main(string[] args)
        {
            double sideOfCube = double.Parse(Console.ReadLine());
            string Parameter = Console.ReadLine();

            CubeProperties(sideOfCube, Parameter);
        }

        public static void CubeProperties(double sideOfCube, string Parameter)
        {
            double faceDiagonal = Math.Sqrt(2 * Math.Pow(sideOfCube, 2));
            double spaceDiagonal = Math.Sqrt(3 * Math.Pow(sideOfCube, 2));
            double volume = Math.Pow(sideOfCube, 3);
            double surfaceArea = 6 * Math.Pow(sideOfCube, 2);

            if (Parameter == "face")
            {
                Console.WriteLine("{0:f2}", faceDiagonal);
            }
            else if (Parameter == "space")
            {
                Console.WriteLine("{0:f2}", spaceDiagonal);
            }
            else if (Parameter == "volume")
            {
                Console.WriteLine("{0:f2}", volume);
            }
            else if (Parameter == "area")
            {
                Console.WriteLine("{0:f2}", surfaceArea);
            }
        }

    }

}
