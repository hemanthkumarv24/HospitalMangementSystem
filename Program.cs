using HospitalMangementSystem;
using HospitalMangementSystem.Interfaces;
using HospitalMangementSystem.Models;
using HospitalMangementSystem.Services;

public class Program
{
    public static void Main(string[] args)
    {
        HospitalService service = new HospitalService();
        INotificationService notificationService = new SMSNotificationService();

        // Create a patient instance
        Person patient = new Patient
        {
            ID = 1,
            Name = "John Doe",
            Age = 30,
            MedicalHistory = "No known allergies"
        };
        // Create a doctor instance
        Person doctor = new Doctor
        {
            ID = 2,
            Name = "Dr. Smith",
            Age = 45,
            Specialization = "Cardiology"
        };
        // Display information for both patient and doctor

        service.persons.Add(patient);
        service.persons.Add(doctor);

        // Display all persons
        Console.WriteLine("\nPersons in the system:");
        foreach (var person in service.persons)
        {
            person.DisplayDetails();
        }

        // Create an appointment
        service.CreateAppointments((Patient)patient, (Doctor)doctor, DateTime.Now, DateTime.Now.AddHours(1));
        // Send notification for the appointment
        string notificationMessage = notificationService.SendNotification(service.GetAppointments().Last());
        Console.WriteLine(notificationMessage);
        // Create a medical record
        service.CreateMedicalRecord((Patient)patient, (Doctor)doctor, "Routine Checkup", "No treatment required");
        // Display all appointments
        Console.WriteLine("\nAppointments:");
        foreach (var appointment in service.GetAppointments())
        {
            Console.WriteLine($"Appointment ID: {appointment.AppointmentID}, Patient: {appointment.patient.Name}, Doctor: {appointment.doctor.Name}, Date: {appointment.date}, Time: {appointment.time}");
        }
        // Display all medical records
        Console.WriteLine("\nMedical Records:");
        foreach (var record in service.GetMedicalRecords())
        {
            Console.WriteLine($"Record ID: {record.RecordID}, Patient: {record.patient.Name}, Doctor: {record.doctor.Name}, Diagnosis: {record.Diagnosis}, Treatment: {record.Treatment}");
        }
        
        
    }
}