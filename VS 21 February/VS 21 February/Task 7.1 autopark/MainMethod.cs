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
            Console.WriteLine($"Bus number {transport.number} goes to {transport.destination}. Departure time: {transport.departureTime}. Number of seats: {transport.numberOfSeats}.");
        }
    }
}

