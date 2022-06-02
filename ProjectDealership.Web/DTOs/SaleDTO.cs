using ProjectDeleaship.Lib.Models;

namespace ProjectDealership.Web.DTOs
{
    public class SaleDTO
    {
        public Client Buyer { get; set; }
        public Employee Seller { get; set; }
        public Vehicle Vehicle { get; set; }
        public string PaymentMethod { get; set; }
        public double FinalAmount { get; set; }
    }
}