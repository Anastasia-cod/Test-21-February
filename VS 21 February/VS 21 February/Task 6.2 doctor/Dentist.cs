using System;
namespace VS_21_February
{
    public class Dentist : Doctor
    {
        protected string position = "Dentist";

        public Dentist(string name, double experience, int qualificationCategory) : base(name, experience, qualificationCategory)
        {
        }

        public override string Treat()
        {
            return $"\nYour doctor: {name}, position: {position}, experience: {experience} years. Qualification category: {qualificationCategory}.\n1.Consultation and inspection;\n2.Direction for x-ray (if necessary);\n3.Studying research results;\n4.Diagnosis;\n5.Prescribing treatment and taking necessary measures";
        }
    }
}

