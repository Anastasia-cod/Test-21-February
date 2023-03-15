using System;
namespace VS_21_February
{
	public class Triangles : Figure
	{
		public double firstSide;
		public double secondSide;
		public double thirdSide;

		public Triangles(double firstSide, double secondSide, double thirdSide)
		{
			this.firstSide = firstSide;
			this.secondSide = secondSide;
			this.thirdSide = thirdSide;
		}

		public override double GetSquare()
		{
			Console.WriteLine("\nGet square Scalene Triangle");
			double semiPerimeter = (firstSide + secondSide + thirdSide) / 2;
			return Math.Sqrt(semiPerimeter * (semiPerimeter - firstSide) * (semiPerimeter - secondSide) * (semiPerimeter - thirdSide));
		}
	}
}

