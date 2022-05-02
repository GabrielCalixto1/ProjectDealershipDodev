namespace ProjectDealership.Models
{
    public class Sale
    {
        private Client Buyer { get; set; }
        private Employee Seller { get; set; }
        private Vehicle Vehicle { get; set; }
        private string PaymentMethod { get; set; }
        private double FinalAmount { get; set; }
        public Sale(Client buyer, Employee seller, Vehicle vehicle, string paymentMethod, double finalAmount) : base()
        {
            SetBuyer(buyer);
            SetSeller(seller);
            SetVehicle(vehicle);
            SetPaymentMethod(paymentMethod);
            SetFinalAmount(finalAmount);

        }
        public void SetBuyer(Client buyer)
        {
            Buyer = buyer;
        }
        public Client GetBuyer()
        {
            return Buyer;
        }
        public void SetSeller(Employee seller)
        {
            Seller = seller;
        }
        public Employee GetSeller()
        {
            return Seller;
        }
        public void SetVehicle(Vehicle vehicle)
        {
            Vehicle = vehicle;
        }
        public Vehicle GetVehicle()
        {
            return Vehicle;
        }
        public void SetPaymentMethod(string paymentMethod)
        {
            PaymentMethod = paymentMethod;
        }
        public string GetPaymentMethod()
        {
            return PaymentMethod;
        }
        public void SetFinalAmount(double finalAmount)
        {
            FinalAmount = finalAmount;
        }
        public double GetFinalAmount()
        {
            return FinalAmount;
        }
        public double ApplyDiscount()
        {
            return 0;
        }

    }

}