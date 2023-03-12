using System;
namespace VS_21_February.Task7.autopark
{
	public class Trolleybus : PublicTransport
	{
        public Trolleybus(string destination, string number, string departureTime, int numberOfSeats, string type) : base(destination, number, departureTime, numberOfSeats, "Electric")
        {
        }

        public Trolleybus(string destination, string number, string departureTime, int numberOfSeats) : this(destination, number, departureTime, numberOfSeats, "Electric")
        {
        }

        public override string ReturnType()
        {
            return $"Troylleybas is a {Type} type";
        }
    }
}

