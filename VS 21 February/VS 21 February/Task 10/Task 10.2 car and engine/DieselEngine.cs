using System;
namespace VS_21_February.Task10.Task10.carandengine
{
	public class DieselEngine : Engine
	{
		public DieselEngine(string type = "Diesel") : base(type)
		{
		}

		public override void GetInfo()
		{
			Console.WriteLine($"The engine is {type}");
		}
	}
}

