namespace PhysicalTherapyClinic.Models
{
    public class AddClinetServiceViewModel
    {
        public string ClientName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string PaymentMethodType { get; set; }
        public Guid CompanyService_Id { get; set; }
        public double EnduranceRatio { get; set; }
    }
}
