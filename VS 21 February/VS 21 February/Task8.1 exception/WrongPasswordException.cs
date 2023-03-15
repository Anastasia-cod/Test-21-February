using System;
namespace VS_21_February.Task8.exception
{
	public class WrongPasswordException : Exception
	{
		public WrongPasswordException(string message) : base(message)
        {
		}
	}
}

