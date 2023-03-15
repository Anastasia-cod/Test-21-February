using System;
namespace VS_21_February
{
	public class Square : Rectangle
	{
		public Square(double length, double width) : base(length, width)
		{
		}

		public override double GetSquare()
		{
			Console.WriteLine("\nGet square Square");
			return Math.Pow(length, 2);
		}
	}
}

