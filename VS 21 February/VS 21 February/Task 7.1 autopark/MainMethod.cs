using System;
namespace VS_21_February.Task7.autopark
{
	public class MainMethod
	{
        Transport transport;
        //Bus bus;
        //Tramcar tramcar;
        //Trolleybus trolleybus;

        public MainMethod(Transport transport)
        {
            this.transport = transport;
            //this.bus = bus;
        }

        public void Main()
        {
            Console.WriteLine($"Bus number {transport.Number} goes to {transport.Destination}. Departure time: {transport.DepartureTime}. Number of seats: {transport.NumberOfSeats}.");
        }
    }
}

