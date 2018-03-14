using Microsoft.EntityFrameworkCore;

namespace PhoneViewPageApp.Models
{
    public class PhoneContext:DbContext
    {
        public PhoneContext(DbContextOptions<PhoneContext> options)
           : base(options)
        { }

        public DbSet<Phone> Phones { get; set; }
    }
}
