using System;
namespace VS_21_February.Task7.autopark
{
	public class Tramcar : Transport
	{
        public Tramcar(string Destination, string Number, string DepartureTime, int NumberOfSeats, string Type) : base(Destination, Number, DepartureTime, NumberOfSeats, "Rail")
        {
        }

        public Tramcar(string Destination, string Number, string DepartureTime, int NumberOfSeats) : this(Destination, Number, DepartureTime, NumberOfSeats, "Rail")
        {
        }

        public override string ReturnType()
        {
            return $"Tramcar is a {Type} type";
        }
    }
}

