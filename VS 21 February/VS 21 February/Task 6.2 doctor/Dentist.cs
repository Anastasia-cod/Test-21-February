using System;
namespace VS_21_February
{
	public class Dentist : Doctor
	{
		public Dentist(string name, double experience, int qualificationCategory) : base(name, experience, qualificationCategory)
		{
		}

        public override string Treat()
        {
            return "\nYour doctor is dentist " + name + " " + "experience - " + experience + " years." + " Qualification category - " + qualificationCategory + ".\n1.Consultation and inspection;\n2.Direction for x-ray (if necessary);\n3.Studying research results;\n4.Diagnosis;\n5.Prescribing treatment and taking necessary measures";
        }
    }
}

