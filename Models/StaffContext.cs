

using Microsoft.EntityFrameworkCore;

namespace SMS.Models
{
    public class StaffContext: DbContext
    {
        public StaffContext(DbContextOptions<StaffContext> options)
            : base(options)
        {
        }

        public DbSet<Staff> TodoItems { get; set; } = null!;
    }
}
