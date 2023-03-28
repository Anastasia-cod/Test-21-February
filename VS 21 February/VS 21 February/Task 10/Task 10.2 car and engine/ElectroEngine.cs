using System;
namespace VS_21_February.Task10.Task10.carandengine
{
    public class ElectroEngine : Engine
    {
        public ElectroEngine(string type = "Electro") : base(type)
        {
        }

        public override void GetInfo()
        {
            Console.WriteLine($"The engine is {type}");
        }
    }
}

