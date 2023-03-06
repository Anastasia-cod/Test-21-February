using System;
namespace VS_21_February
{
	public class Phone
	{
		public string number;
		public string model;
		public double weight;
		public string callerName;
		public long phoneNumber;

        public Phone(string number, string model, double weight)
        {
            this.number = number;
            this.model = model;
            this.weight = weight;
        }

        public Phone(string number, string model) : this(number, model, 0)
        {

        }

        public Phone()
        {

        }

        public void ReceiveCall(string nameOfPerson)
        {
            callerName = nameOfPerson;
            Console.WriteLine($"Calling: {callerName}");
        }

        public long GetNumber()
        {
            return phoneNumber;
        }

        public void ReceiveCall(string nameOfPerson, long phone)
        {
            callerName = nameOfPerson;
            phoneNumber = phone;

            Console.WriteLine($"Calling: {callerName} the phone number is {phoneNumber}");
        }

        public void SendMessage(params long[] phoneNumbers)
        {
           if (phoneNumbers.Length == 0)
            {
                Console.WriteLine($"\nError! There is no phone numbers");
            }

            foreach (long number in phoneNumbers)
            {
                Console.Write(number + " ");
            }
        }
    }
}

