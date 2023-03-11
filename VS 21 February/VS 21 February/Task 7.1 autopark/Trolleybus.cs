using System;
namespace VS_21_February.Task7.autopark
{
	public class Trolleybus : Transport
	{
        public Trolleybus(string Destination, string Number, string DepartureTime, int NumberOfSeats, string Type) : base(Destination, Number, DepartureTime, NumberOfSeats, "Electric")
        {
        }

        public Trolleybus(string Destination, string Number, string DepartureTime, int NumberOfSeats) : this(Destination, Number, DepartureTime, NumberOfSeats, "Electric")
        {
        }

        public override string ReturnType()
        {
            return $"Troylleybas is a {Type} type";
        }
    }
}

