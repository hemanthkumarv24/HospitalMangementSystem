

using HospitalMangementSystem.Interfaces;

namespace HospitalMangementSystem.Services
{
    public class BillingService:IBillable
    {
        public string GenerateBill()
        {
            return "Bill generated successfully.";
        }
    }
    
}
