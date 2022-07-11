namespace PhysicalTherapyClinic.Domain.Entities
{
    public class Service : BaseEntity
    {
        public Service()
        {
            CompanyServices = new HashSet<CompanyService>();
        }

        public string Service_Name { get; set; }
        public virtual ICollection<CompanyService> CompanyServices { get; set; }

    }
}
