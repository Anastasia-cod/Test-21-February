using System;
namespace VS_21_February
{
	public class EquilateralTriangle : Triangles
	{
		public EquilateralTriangle(double firstSide, double secondSide, double thirdSide) : base(firstSide, secondSide, thirdSide)
		{
		}

		public override double GetSquare()
		{
			Console.WriteLine("\nGet square Equilateral Triangle");
			return Math.Sqrt(3) / 4 * Math.Pow(firstSide, 2);
		}
	}
}

