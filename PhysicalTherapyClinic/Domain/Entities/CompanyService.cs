namespace PhysicalTherapyClinic.Domain.Entities
{
    public class CompanyService : BaseEntity
    {
        public CompanyService()
        {
            ClientServices = new HashSet<ClientService>();
        }
        public Guid Service_Id { get; set; }
        public Guid Company_Id { get; set; }
        public double Price { get; set; }
        public virtual Company Company { get; set; }
        public virtual Service Service { get; set; }
        public virtual ICollection<ClientService> ClientServices { get; set; }
    }
}
