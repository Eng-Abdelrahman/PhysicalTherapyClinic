namespace PhysicalTherapyClinic.Models
{
    public class ClientServiceViewModel
    {
        public Guid Id { get; set; }
        public string ClientName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string PaymentMethod { get; set; }
        public string CompanyName { get; set; }
        public string ServiceName { get; set; }
        public double ServicePrice { get; set; }
        public double EnduranceRatio { get; set; }
    }
}
