using System;
namespace VS_21_February
{
	public class Doctor
	{
		public string name;
		public double experience;
		public int qualificationCategory;

        public Doctor(string name, double experience, int qualificationCategory)
		{
			this.name = name;
			this.experience = experience;
			this.qualificationCategory = qualificationCategory;
		}

		public virtual string Treat()
		{
			return "In order to prescribe treatment, you need to come to the therapist, describe the complaints.\nThe therapist will either prescribe you treatment or refer you to the right specialist";
        }
	}
}

