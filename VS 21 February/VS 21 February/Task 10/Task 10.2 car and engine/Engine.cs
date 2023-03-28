using System;
namespace VS_21_February.Task10.Task10.carandengine
{
    public abstract class Engine
    {
        public string type;

        public Engine(string type)
        {
            this.type = type;
        }

        public virtual void GetInfo()
        {
            Console.WriteLine("The engine is abstract");
        }
    }
}

