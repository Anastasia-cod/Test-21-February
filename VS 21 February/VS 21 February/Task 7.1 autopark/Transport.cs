using System;
namespace VS_21_February.Task7.autopark
{
	public abstract class Transport
	{
        public string type;
        public string destination { get; set; }
        public string number { get; set; }
        public string departureTime { get; set; }
        public int numberOfSeats { get; set; }

        public Transport(string destination, string number, string departureTime, int numberOfSeats, string type)
		{
            this.destination = destination;
            this.number = number;
            this.departureTime = departureTime;
            this.numberOfSeats = numberOfSeats;
            this.type = type;
		}

		public virtual string ReturnType()
		{
			return $"This transport is {type}";
		}
	}
}

