using System;
namespace VS_21_February
{
	public class IsoscelesTriangle : Triangles
	{
		public IsoscelesTriangle(double firstSide, double secondSide, double thirdSide) : base(firstSide, secondSide, thirdSide)
		{
		}

        public override double GetSquare()
        {
            Console.WriteLine("\nGet square Isosceles Triangle");

            if (firstSide == secondSide && firstSide != thirdSide)
            {
                return GetSquareForIsoscelesTriangle(thirdSide, firstSide);
            }
            else if(firstSide == thirdSide && firstSide != secondSide)
            {
                return GetSquareForIsoscelesTriangle(secondSide, firstSide);
            }
            else
            {
                return GetSquareForIsoscelesTriangle(firstSide, secondSide);
            }
        }

        public double GetSquareForIsoscelesTriangle(double firstSide, double secondSide)
        {
            return firstSide / 2 * Math.Sqrt((Math.Pow(secondSide, 2) - Math.Pow((firstSide / 2), 2)));
        }
    }
}

