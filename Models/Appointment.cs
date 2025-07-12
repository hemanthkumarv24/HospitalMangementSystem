
namespace HospitalMangementSystem.Models
{
    public class Appointment
    {
        public int AppointmentID { get; set; }
        public Patient patient { get; set; }

        public Doctor doctor { get; set; }

        public DateTime date { get; set; }

        public DateTime time { get; set; }


    }
}
