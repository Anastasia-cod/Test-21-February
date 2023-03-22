using System;
namespace VS_21_February.Task10.point
{
	public class Point <T>
	{
		public T x;
		public T y;
		public T X { get; set; }
		public T Y { get; set; }

		public Point(T x, T y)
		{
			this.x = x;
			this.y = y;
		}

		public void GetInfo()
		{
			Console.WriteLine($"Сoordinate x: {x}. Coordinate y: {y}");
		}

		public void GetDistanceBetweenTwoPoints()
		{

		}
	}
}

