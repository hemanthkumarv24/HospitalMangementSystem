namespace HospitalMangementSystem.Models
{
    public class Patient : Person
    {
        public string MedicalHistory { get; set; }
        public override void DisplayDetails()
        {
            Console.WriteLine($"Patient ID: {ID}, Name: {Name}, Age: {Age}, Medical History: {MedicalHistory}");
        }
    }
   
}
