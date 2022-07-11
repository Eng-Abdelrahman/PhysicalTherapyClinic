namespace PhysicalTherapyClinic.Domain.Entities
{
    public class BaseEntity
    {
        public Guid Id { get; set; }
        //public Guid Created_By { get; set; }
        public DateTime Create_Date { get; set; }
        //public Nullable<Guid> Last_Modified_By { get; set; }
        public Nullable<DateTime> Last_Modify_Date { get; set; }
        //public bool Is_Active { get; set; }
        public bool Is_Deleted { get; set; }
    }
}
