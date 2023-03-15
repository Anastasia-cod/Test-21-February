using System;
namespace VS_21_February.Task8.exception
{
	public class WrongLoginException : Exception
	{
		public WrongLoginException(string message) : base(message)
		{
		}
	}
}

