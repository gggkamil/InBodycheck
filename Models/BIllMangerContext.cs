using Microsoft.EntityFrameworkCore;

namespace InBodycheck.Models
{
    public class BIllMangerContext : DbContext
    {
        public BIllMangerContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<BillModel> Bills { get; set; }
    }
}
