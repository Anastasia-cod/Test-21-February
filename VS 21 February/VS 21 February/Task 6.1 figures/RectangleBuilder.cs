using System;
namespace VS_21_February
{
	public class RectangleBuilder
	{
		public RectangleBuilder()
		{
		}

		public Rectangle CreateRectangle(double length, double width)
		{
			if (length == width)
			{
				return new Square(length, width);
			}
			else
			{
				return new Rectangle(length, width);
			}
		}
	}
}

