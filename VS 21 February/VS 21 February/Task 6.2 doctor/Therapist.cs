using System;
namespace VS_21_February
{
	public class Therapist : Doctor
	{
		public Therapist(string name, double experience, int qualificationCategory) : base(name, experience, qualificationCategory)
		{
		}

		public override string Treat()
		{
            return "\nYour doctor is therapist " + name + " " + "experience - " + experience + " years." + " Qualification category - " + qualificationCategory + ".\n1.Consultation and inspection;\n2.Studying the medical history (anamnesis);\n3.Referral for necessary research;\n4.Studying research results;\n5.Diagnosis;\n6.Prescribing treatment or referral to a highly specialized specialist";
        }

    }
}

