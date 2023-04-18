using Final_SophieTravelManagement.Domain.Entities;
using Final_SophieTravelManagement.Domain.ValueObjects;
using Final_SophieTravelManagement.Infrastructure.EF.Config;
using Final_SophieTravelManagement.Infrastructure.EF.Models;
using Microsoft.EntityFrameworkCore;

namespace Final_SophieTravelManagement.Infrastructure.EF.Contexts
{
    public sealed class WriteDbContext:DbContext
    {
       
        public DbSet<TravelerCheckList> TravelerCheckList { get; set; }

        public WriteDbContext(DbContextOptions<WriteDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           // modelBuilder.HasDefaultschema("TravelerCheckList");
          

            var configuration = new WriteConfiguration();
            modelBuilder.ApplyConfiguration<TravelerCheckList>(configuration);
            modelBuilder.ApplyConfiguration<TravelerCheckListItem>(configuration);
            base.OnModelCreating(modelBuilder);
        }
    }
}
