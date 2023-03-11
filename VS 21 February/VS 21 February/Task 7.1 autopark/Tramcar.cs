using System;
namespace VS_21_February.Task7.autopark
{
	public class Tramcar : Transport
	{
		public Tramcar(string destination, string number, string departureTime, int numberOfSeats, string type) : base(destination, number, departureTime, numberOfSeats, "Rail")
        {
		}

        public Tramcar(string destination, string number, string departureTime, int numberOfSeats) : this(destination, number, departureTime, numberOfSeats, "Rail")
        {
        }

        public override string ReturnType()
        {
            return $"Tramcar is a {type} type";
        }
    }
}

