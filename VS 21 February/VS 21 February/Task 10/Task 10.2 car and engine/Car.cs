using System;
namespace VS_21_February.Task10.Task10.carandengine
{
    public class Car<T>
    {
        public T engineCar;
        Engine engine;
        public string model;
        public double maxSpeed = 240;
        public double speed;
        public double volumeOfTheTank = 80;
        public double remainingFuel;
        public double maxVolumeOfTheTank = 80;
        public int currentbatteryCharge;
        public int maxBatteryCharge = 100;

        public Car(Engine someEngine, string model, double remainingFuel)
        {
            engine = someEngine;
            this.model = model;
            this.remainingFuel = remainingFuel;
        }

        public Car(Engine someEngine, string model, int currentbatteryCharge)
        {
            engine = someEngine;
            this.model = model;
            this.currentbatteryCharge = currentbatteryCharge;
        }

        /// <summary>
        /// Move the car depending on the type of engine
        /// </summary>
        public void MoveCar()
        {
            if(this.engine.type == "Diesel" && speed < maxSpeed)
            {
                speed += 20;
            }
            else if(this.engine.type == "Petrol" && speed < maxSpeed)
            {
                speed += 40;
            }
            else if(this.engine.type == "Electro" && speed < maxSpeed)
            {
                speed += 60;
            }
            else
            {
                speed = 0;
            }
            Console.WriteLine($"The car {this.engine.type} is moving at a speed: {speed} km/hour");
        }

        /// <summary>
        /// Fill up the tank depending on the type of engine
        /// </summary>
        public void FillUpTheTank()
        {
            var maxAbilityToFillUp = maxVolumeOfTheTank - remainingFuel;
            var maxAbilityToCharge = maxBatteryCharge - currentbatteryCharge;

            if (this.engine.type == "Diesel" && remainingFuel < maxVolumeOfTheTank)
            {
                remainingFuel = maxAbilityToFillUp / 2;

                Console.WriteLine($"The car is filled up to: {remainingFuel} liters");
            }
            else if (this.engine.type == "Petrol" && remainingFuel < maxVolumeOfTheTank)
            {
                remainingFuel = maxAbilityToFillUp / 4;

                Console.WriteLine($"The car is filled up to: {remainingFuel} liters");
            }
            else if (this.engine.type == "Electro" && currentbatteryCharge < maxBatteryCharge)
            {
                remainingFuel = maxAbilityToCharge/ 2;

                Console.WriteLine($"The car is charge to: {remainingFuel} percents");
            }
            else
            {
                remainingFuel = 0;
            }			
        }
    }
}

