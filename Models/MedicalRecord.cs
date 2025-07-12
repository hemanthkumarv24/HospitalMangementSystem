
namespace HospitalMangementSystem.Models
{
    public class MedicalRecord
    {
        public int RecordID { get; set; }
        public Patient patient { get; set; }
        public Doctor doctor { get; set; }
        public string Diagnosis { get; set; }
        public string Treatment { get; set; }

    }
}
