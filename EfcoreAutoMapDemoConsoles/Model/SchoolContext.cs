using EfcoreAutoMapDemoConsoles.Map;
using Microsoft.EntityFrameworkCore;

namespace EfcoreAutoMapDemoConsoles.Model
{
    public class SchoolContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("Server=localhost;port=3306;database=test;uid=root;pwd=root;Convert Zero Datetime=True;", b => b.MaxBatchSize(30));
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new StudentsMap());
        }
    }
}
