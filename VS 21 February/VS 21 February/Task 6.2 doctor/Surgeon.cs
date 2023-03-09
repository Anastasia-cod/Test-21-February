using System;
namespace VS_21_February
{
	public class Surgeon : Doctor
	{
		public Surgeon(string name, double experience, int qualificationCategory) :base(name, experience, qualificationCategory)
		{
		}

        public override string Treat()
        {
            return "\nYour doctor is surgeon " + name + " " + "experience - " + experience + " years." + " Qualification category - " + qualificationCategory + ".\n1.Consultation and inspection;\n2.Ordering necessary blood tests and ultrasounds;\n3.Study of the results of laboratory and hardware studies;\n4.Diagnosis;\n5.Appointment and conduct of the operation;\n6.Drawing up a rehabilitation plan for a quick recovery.";
        }
    }
}

