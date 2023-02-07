using Microsoft.EntityFrameworkCore;
using sqllitecodefirst.Entities;

namespace sqllitecodefirst.Contexts
{
    public class AthleteSQLiteDbContext : DbContext
    {
        // database  bagli  tablo baglanmasi
        public DbSet<Athlete> Athletes { get; set; }
       //database  baglantisinin  optimize  edilmesi 
        public AthleteSQLiteDbContext(DbContextOptions<AthleteSQLiteDbContext> options) : base(options)
        { }
        protected override void OnModelCreating(ModelBuilder modelBuider)
        {
            base.OnModelCreating(modelBuider);
        }
    }
}
