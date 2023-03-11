using System;
namespace VS_21_February.Task7.autopark
{
	public abstract class Transport
    {
        public string Type { get; set; }
        public string Destination { get; set; }
        public string Number { get; set; }
        public string DepartureTime { get; set; }
        public int NumberOfSeats { get; set; }

        public Transport(string Destination, string Number, string DepartureTime, int NumberOfSeats, string Type)
        {
            this.Destination = Destination;
            this.Number = Number;
            this.DepartureTime = DepartureTime;
            this.NumberOfSeats = NumberOfSeats;
            this.Type = Type;
        }

        public abstract string ReturnType();

        //public int CompareTo(object obj)
        //{
        //    if (obj is Transport)
        //    {
        //        Transport c2 = (Transport)obj;
        //        return CompareTo(c2.NumberOfSeats);
        //    }               
        //    else
        //        throw new ArgumentException("Object is not of type Transport");
        //}
    }
}

