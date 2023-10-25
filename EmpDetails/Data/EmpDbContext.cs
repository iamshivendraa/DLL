using EmpDetails;
using Microsoft.EntityFrameworkCore;
namespace EmpModelDLL.Data
{
    public class EmpDbContext  : DbContext
    {
        public EmpDbContext(DbContextOptions<EmpDbContext> options) : base(options) { }
        public DbSet<EmpModel> Emp{ get; set; }
    }
}
