namespace HospitalMangementSystem.Models
{
    public class Doctor:Person
    {
        public string Specialization { get; set; }
        public override void DisplayDetails()
        {
            Console.WriteLine($"Doctor ID: {ID}, Name: {Name}, Age: {Age}, Specialization: {Specialization}");
        }
    }
}
