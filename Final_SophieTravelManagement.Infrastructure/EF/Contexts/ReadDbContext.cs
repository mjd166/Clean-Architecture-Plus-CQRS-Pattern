using Final_SophieTravelManagement.Infrastructure.EF.Config;
using Final_SophieTravelManagement.Infrastructure.EF.Models;
using Microsoft.EntityFrameworkCore;

namespace Final_SophieTravelManagement.Infrastructure.EF.Contexts
{
    public sealed class ReadDbContext:DbContext
    {
        public DbSet<TravelerCheckListReadModel> TravelerCheckList { get; set; }

        public ReadDbContext(DbContextOptions<ReadDbContext> options):base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.HasDefaultschema("TravelerCheckList");
            base.OnModelCreating(modelBuilder);

            var configuration = new ReadConfiguration();
            modelBuilder.ApplyConfiguration<TravelerCheckListReadModel>(configuration);
            modelBuilder.ApplyConfiguration<TravelerItemReadModel>(configuration);
        }
    }
}
