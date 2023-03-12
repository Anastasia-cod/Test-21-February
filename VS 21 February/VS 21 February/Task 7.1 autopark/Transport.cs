using System;
namespace VS_21_February.Task7.autopark
{
	public abstract class Transport
	{
        public Transport()
        {
        }

        //Select a method in the superclass that cannot be overridden in descendant classes
        //and forbid that overriding.
        public virtual void NumberOfTrips()
        {
            Console.WriteLine("The number of trips is unknown");
        }
    }
}

