
using HospitalMangementSystem.Models;

namespace HospitalMangementSystem.Services
{
    public class HospitalService
    {
        ///Appointment Booking///
        public int AppointmentID = 1;
        public int MedicalRecordID = 1;
        List<Appointment> appointments = new List<Appointment>();
        List<MedicalRecord> medicalRecords = new List<MedicalRecord>();


        public List<Person> persons = new List<Person>();

        public List<Appointment> GetAppointments()
        {
            return appointments;
        }

        public List<MedicalRecord> GetMedicalRecords()
        {
            return medicalRecords;
        }


        public void CreateAppointments(Patient patient, Doctor doctor, DateTime date, DateTime time)
        {
         if (patient == null || doctor == null)
            {
                throw new ArgumentNullException("Patient or Doctor cannot be null");
            }
            Appointment appointment = new Appointment
            {
                AppointmentID = AppointmentID++,
                patient = patient,
                doctor = doctor,
                date = date,
                time = time
            }; 
            appointments.Add(appointment);
        }

        public void CreateMedicalRecord(Patient patient, Doctor doctor, string diagnosis, string treatment)
        {
            if (patient == null || doctor == null)
            {
                throw new ArgumentNullException("Patient or Doctor cannot be null");
            }
            MedicalRecord medicalRecord = new MedicalRecord
            {
                RecordID = MedicalRecordID++,
                patient = patient,
                doctor = doctor,
                Diagnosis = diagnosis,
                Treatment = treatment
            };
            medicalRecords.Add(medicalRecord);
        }

    }
}
