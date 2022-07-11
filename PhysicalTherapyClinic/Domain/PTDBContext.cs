using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PhysicalTherapyClinic.Domain.Entities;

namespace PhysicalTherapyClinic.Domain
{
    public class PTDBContext : IdentityDbContext
    {
        public PTDBContext(DbContextOptions<PTDBContext> options) : base(options)
        {

        }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);


            builder.Entity<Client>(b =>
            {
                b.HasMany(q => q.ClientServices).WithOne(q => q.Client).HasForeignKey(q => q.Client_Id).IsRequired();
            });

            builder.Entity<Company>(b =>
            {
                b.HasMany(q => q.CompanyServices).WithOne(q => q.Company).HasForeignKey(q => q.Company_Id).IsRequired();
            });

            builder.Entity<Service>(b =>
            {
                b.HasMany(q => q.CompanyServices).WithOne(q => q.Service).HasForeignKey(q => q.Service_Id).IsRequired();
            });

            builder.Entity<ClientService>(b =>
            {
                b.HasOne(q => q.Client).WithMany(q => q.ClientServices).HasForeignKey(q => q.Client_Id).IsRequired();
                b.HasOne(q => q.CompanyService).WithMany(q => q.ClientServices).HasForeignKey(q => q.Company_Service_Id).IsRequired();
            });

            builder.Entity<CompanyService>(b =>
            {
                b.HasOne(q => q.Company).WithMany(q => q.CompanyServices).HasForeignKey(q => q.Company_Id).IsRequired();
                b.HasOne(q => q.Service).WithMany(q => q.CompanyServices).HasForeignKey(q => q.Service_Id).IsRequired();
            });

        }

        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<Service> Services { get; set; }
        public virtual DbSet<ClientService> ClientServices { get; set; }
        public virtual DbSet<CompanyService> CompanyServices { get; set; }

    }
}
