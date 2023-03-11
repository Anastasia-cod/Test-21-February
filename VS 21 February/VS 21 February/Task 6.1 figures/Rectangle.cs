using System;
namespace VS_21_February
{
	public class Rectangle : Figure
	{
        public double length;
        public double width;

        public Rectangle(double length, double width) 
        {
            this.length = length;
            this.width = width;
        }

        public override double GetSquare()
        {
            Console.WriteLine("\nGet square Rectangle");
            return length * width;
        }
    }
}

