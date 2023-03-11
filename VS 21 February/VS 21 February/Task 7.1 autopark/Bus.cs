using System;
using System.Data;

namespace VS_21_February.Task7.autopark
{
	public class Bus : Transport
	{

        public Bus(string destination, string number, string departureTime, int numberOfSeats, string type) : base(destination, number, departureTime, numberOfSeats, "Fuel")
		{
        }

        public Bus(string destination, string number, string departureTime, int numberOfSeats) : this (destination, number, departureTime, numberOfSeats, "Fuel")
        {
        }

        public override string ReturnType()
        {
            return $"Bus is a {type} type";
        }
    }
}

