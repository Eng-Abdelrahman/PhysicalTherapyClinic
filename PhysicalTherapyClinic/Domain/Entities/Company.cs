namespace PhysicalTherapyClinic.Domain.Entities
{
    public class Company : BaseEntity
    {
        public Company()
        {
            CompanyServices = new HashSet<CompanyService>();
        } 

        public string Company_Name { get; set; }   

       public virtual ICollection<CompanyService> CompanyServices { get; set; } 
    }
}
