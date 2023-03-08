using System;
namespace VS_21_February
{
	public class TriangleBuilder
	{
		public TriangleBuilder()
		{
		}

		public Triangles CreateTriangle(double firstSide, double secondSide, double thirdSide)
		{
			if(firstSide == secondSide && firstSide == thirdSide)
			{
                return new EquilateralTriangle(firstSide, secondSide, thirdSide);
            }

            return new Triangles(firstSide, secondSide, thirdSide);
		}
	}
}

