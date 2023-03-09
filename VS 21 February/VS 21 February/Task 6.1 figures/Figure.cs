using System;
namespace VS_21_February
{
	public class Figure
	{
		public Figure()
		{
		}

		public virtual string GetInfo(string figureName)
		{
			return $"This is the {figureName}";
		}
	}
}

