using System;
namespace VS_21_February.Task10.point
{
    public class Point <T> where T : struct
    {
        public T x;
        public T y;

        public T X {get; set;}

        public T Y {get; set;}

        public Point(T x, T y)
        {
            this.x = x;
            this.y = y;
        }

        /// <summary>
        /// Get info about Point
        /// </summary>
        public void GetInfo()
        {
            Console.WriteLine($"\nСoordinate x: {x}. Coordinate y: {y}");
        }

        /// <summary>
        /// Get distance beetween two coordinate Point_1(x; y) and Point_2(x; y)
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        public void GetDistanceBetweenTwoPoints(Point<T> first, Point<T> second)
        {
            double x_First = Convert.ToDouble(first.x);
            double y_First = Convert.ToDouble(first.y);
            double x_Second = Convert.ToDouble(second.x);
            double y_Second = Convert.ToDouble(second.y);

            var distanceBetweenTwoPoint = Math.Sqrt(Math.Pow((x_First - x_Second), 2) + Math.Pow((y_First - y_Second), 2));

            Console.WriteLine($"Distance beetween two points: {distanceBetweenTwoPoint}");
        }
    }
}

