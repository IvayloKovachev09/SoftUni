using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Circles_Intersection
{
    class Program
    {
        static void Main()
        {
            int[] firstCircleParams = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] secondCircleParams = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Circle firstCircle = new Circle();
            firstCircle.Radius = firstCircleParams[2];
            Point firstPoint = new Point();
            firstPoint.X = firstCircleParams[0];
            firstPoint.Y = firstCircleParams[1];
            firstCircle.Center = firstPoint;

            Circle secondCircle = new Circle();
            secondCircle.Radius = secondCircleParams[2];
            Point secondPoint = new Point();
            secondPoint.X = secondCircleParams[0];
            secondPoint.Y = secondCircleParams[1];
            secondCircle.Center = secondPoint;

            if (Circle.Intersect(firstCircle, secondCircle))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

        }
    }
    public class Circle
    {
        public int Radius { get; set; }
        public Point Center { get; set; }

        public static bool Intersect(Circle firstCircle, Circle secondcircle)
        {
            int deltaX = Math.Abs(firstCircle.Center.X - secondcircle.Center.X);
            int deltaY = Math.Abs(firstCircle.Center.Y - secondcircle.Center.Y);
            double distans = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);

            int radiusSum = firstCircle.Radius + secondcircle.Radius;
            if (distans<=radiusSum)
            {
                return true;
            }
               return false;
            

        }
    }
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
}
