using System;
namespace VS_21_February
{
	public class Patient
	{
        public string name;
        public int age;

        public Patient(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void GetInfo()
        {
            Console.WriteLine($"The patient name is {name}, age is {age}");
        }
    }
}

