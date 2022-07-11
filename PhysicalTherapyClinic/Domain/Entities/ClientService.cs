namespace PhysicalTherapyClinic.Domain.Entities
{
    public class ClientService : BaseEntity
    {
        public Guid Client_Id { get; set; }
        public Guid Company_Service_Id { get; set; }
        public double Service_Price { get; set; }
        public string Payment_Method { get; set; }
        public double Endurance_Ratio { get; set; }
        public virtual Client Client { get; set; }
        public virtual CompanyService CompanyService { get; set; }
    }
}