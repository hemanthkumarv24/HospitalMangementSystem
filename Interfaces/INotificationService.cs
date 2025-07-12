
using HospitalMangementSystem.Models;

namespace HospitalMangementSystem.Interfaces
{
    public interface INotificationService
    {
        public string SendNotification(Appointment appointment);
    }
}
