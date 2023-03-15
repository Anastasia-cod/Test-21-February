using System;
namespace VS_21_February.Task8.exception
{
	public class WrongLoginException : Exception
	{
		public string Detail { get; set; }

        public WrongLoginException(string message) : base(message)
        {
        }
    }
}

