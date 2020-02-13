namespace _3.IntersectionOfCircles
{
    using System;
   
    public class IntersectionOfCircles
    {
        public static void Main()
        {
            var inputNumbers = Console.ReadLine().Split(' ');
            var firstPoint = new Point
            {
                X = int.Parse(inputNumbers[0]),
                Y = int.Parse(inputNumbers[1])
            };
            var firstRadius = int.Parse(inputNumbers[2]);

            inputNumbers = Console.ReadLine().Split(' ');
            var secondPoint = new Point
            {
                X = int.Parse(inputNumbers[0]),
                Y = int.Parse(inputNumbers[1])
            };
            var secondRadius = int.Parse(inputNumbers[2]);
            
            IntersectionOfCircles Intersection = new IntersectionOfCircles();
            var inter = Intersection.Intersect(firstPoint, secondPoint, firstRadius, secondRadius);

            if (inter)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
            
        }

        public bool Intersect(Point firstPoint, Point secondPoint,int firstRadius,int secondRadius)
        {
            var diffX = firstPoint.X - secondPoint.X;
            var diffY = firstPoint.Y - secondPoint.Y;
            var powX = Math.Pow(diffX, 2);
            var powY = Math.Pow(diffY, 2);
            var pointsDistance = Math.Sqrt(powX + powY);

            bool IntersectOrNot = false;
            if (pointsDistance <= firstRadius + secondRadius)
            {
                IntersectOrNot = true;
            }
            else if (pointsDistance > firstRadius + secondRadius)
            {
                IntersectOrNot = false;
            }
            return IntersectOrNot;
        }
    }
}
