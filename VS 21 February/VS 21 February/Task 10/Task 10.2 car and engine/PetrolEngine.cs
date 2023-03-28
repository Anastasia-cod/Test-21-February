using System;
namespace VS_21_February.Task10.Task10.carandengine
{
    public class PetrolEngine : Engine
    {
        public PetrolEngine(string type = "Petrol") : base(type)
        {
        }

        public override void GetInfo()
        {
            Console.WriteLine($"The engine is {type}");
        }
    }
}

