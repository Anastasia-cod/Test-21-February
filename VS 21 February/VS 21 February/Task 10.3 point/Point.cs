using System;
namespace VS_21_February.Task10.point
{
	public class Point <T> where T : struct
	{
		public T x;
		public T y;

		public T X
		{
			get { return x; }
			set { x = value; }
		}

		public T Y
		{
			get { return y; }
			set { y = value; }
		}

		public Point(T x, T y)
		{
			this.x = x;
			this.y = y;
		}

		public void GetInfo()
		{
			Console.WriteLine($"Сoordinate x: {x}. Coordinate y: {y}");
		}

		public void GetDistanceBetweenTwoPoints(Point<double> first, Point<double> second)
		{
			var distanceBetweenTwoPoint = Math.Sqrt(Math.Pow((first.X - second.X), 2) + Math.Pow((first.Y - second.Y), 2));

			Console.WriteLine($"Distance beetween two point: {distanceBetweenTwoPoint}");
		}

		public void GetDistanceBetweenTwoPoints(Point<int> first, Point<int> second)
		{
			var distanceBetweenTwoPoint = Math.Sqrt(Math.Pow((first.X - second.X), 2) + Math.Pow((first.Y - second.Y), 2));

			Console.WriteLine($"Distance beetween two points: {distanceBetweenTwoPoint}");
		}
	}
}

