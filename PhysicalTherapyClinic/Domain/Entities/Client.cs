namespace PhysicalTherapyClinic.Domain.Entities
{
    public class Client : BaseEntity
    {
        public Client()
        {
            ClientServices = new HashSet<ClientService>();
        }
        public string Client_Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public virtual ICollection<ClientService> ClientServices { get; set; }
    }
}
