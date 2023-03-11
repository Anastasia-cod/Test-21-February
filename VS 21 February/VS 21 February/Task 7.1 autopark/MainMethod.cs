using System;
namespace VS_21_February.Task7.autopark
{
	public class MainMethod
	{
		Bus bus;

		public MainMethod(Bus bus)
		{
			this.bus = bus;
		}

        public void Main()
        {
            Console.WriteLine($"Bus number {bus.number} goes to {bus.destination}. Departure time: {bus.departureTime}. Number of seats: {bus.numberOfSeats}.");
        }


    }
}

