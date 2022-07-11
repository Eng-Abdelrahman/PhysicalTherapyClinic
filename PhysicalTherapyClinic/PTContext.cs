using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace PhysicalTherapyClinic
{
    public class PTContext : IdentityDbContext
    {
        public PTContext(DbContextOptions<PTContext> options) : base(options)
        {

        }
    }
}
