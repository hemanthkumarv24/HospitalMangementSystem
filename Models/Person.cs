namespace HospitalMangementSystem.Models
{
    public abstract class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public int ID { get; set; }

        public abstract void DisplayDetails();
    }
}
