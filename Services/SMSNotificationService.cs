
using HospitalMangementSystem.Interfaces;
using HospitalMangementSystem.Models;

namespace HospitalMangementSystem.Services
{
    public class SMSNotificationService:INotificationService
    {
        /// <summary>
        /// Sends an SMS notification on successful appointment booking and returns a confirmation message.
        /// </summary>
        /// <returns>A string indicating that the SMS notification was sent successfully.</returns>
        public string SendNotification(Appointment appointment)
        {
            if(appointment == null)
            {
                throw new ArgumentNullException(nameof(appointment), "Appointment cannot be null");
            }
            string message = $"SMS Notification: Appointment booked successfully for {appointment.patient.Name} with Dr. {appointment.doctor.Name} on {appointment.date.ToShortDateString()} at {appointment.time.ToShortTimeString()}.";
            return message;
        }

    }
}
