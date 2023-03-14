using System;
using System.Xml.Linq;

namespace VS_21_February
{
	public class TreatmentPlan
	{
		Doctor doctor;
		Patient patient;
		public int code;

		public TreatmentPlan(Patient patient, int code, Doctor doctor)
		{
			this.patient = patient;
			this.code = code;
			this.doctor = doctor;
		}

		public Doctor SelectDoctor(Patient patient, int code, Doctor doctor)
		{
			Console.WriteLine($"\nThe patient: {patient.name}, age: {patient.age}.");

			if (code == 1)
			{
				return new Surgeon(doctor.name, doctor.experience, doctor.qualificationCategory);
			}
			else if (code == 2)
			{
				return new Dentist(doctor.name, doctor.experience, doctor.qualificationCategory);
			}
			else
			{
				return new Therapist(doctor.name, doctor.experience, doctor.qualificationCategory);
			}
		}
	}
}

