using System;
using System.Xml.Linq;

namespace VS_21_February.Task7.autopark
{
	public abstract class PublicTransport : Transport, IGetInfo
	{
        public string Type { get; set; }
        public string Destination { get; set; }
        public string Number { get; set; }
        public string DepartureTime { get; set; }
        public int NumberOfSeats { get; set; }

        public PublicTransport(string destination, string number, string departureTime, int numberOfSeats, string type)
        {
            Destination = destination;
            Number = number;
            DepartureTime = departureTime;
            NumberOfSeats = numberOfSeats;
            Type = type;
        }

        public abstract string ReturnType();

        //Select a method in the superclass that cannot be overridden in descendant classes
        //and forbid that overriding.
        public override sealed void NumberOfTrips()
        {
            base.NumberOfTrips();
        }

        public void GetInfo()
        {
            Console.WriteLine($"Transport number {Number} goes to {Destination}. Departure time: {DepartureTime}. Number of seats: {NumberOfSeats}");
        }

        public override string ToString()
        {
            return $"Transport type is {Type}. Destination: {Destination}. Transport number: {Number}. Departure time: {DepartureTime}. Number of seats: {NumberOfSeats}";
        }
    }
}

