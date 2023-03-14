using System;
namespace VS_21_February
{
	public class RightTriangle : Triangles
	{
		public RightTriangle(double firstSide, double secondSide, double thirdSide) : base(firstSide, secondSide, thirdSide)
		{
		}

		public override double GetSquare()
		{
			Console.WriteLine("\nGet square Right Triangle");

			if (firstSide > secondSide)
			{
				if (firstSide > thirdSide)
				{
					return GetSquareForRightTriangle(secondSide, thirdSide);
				}
				else
				{
					return GetSquareForRightTriangle(firstSide, secondSide);
				}
			}
			else
			{
				if (secondSide > thirdSide)
				{
					return GetSquareForRightTriangle(firstSide, thirdSide);
				}
				else
				{
					return GetSquareForRightTriangle(firstSide, secondSide);
				}
			}
		}

		public double GetSquareForRightTriangle(double firstSide, double secondSide)
		{
			return 0.5 * firstSide * secondSide;
		}
	}
}

