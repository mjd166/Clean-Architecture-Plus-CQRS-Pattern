using Final_SophieTravelManagement.Infrastructure.EF.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Final_SophieTravelManagement.Infrastructure.EF.Config
{
    internal sealed class ReadConfiguration : IEntityTypeConfiguration<TravelerCheckListReadModel>,IEntityTypeConfiguration<TravelerItemReadModel>
    {
        public void Configure(EntityTypeBuilder<TravelerCheckListReadModel> builder)
        {
            builder.ToTable("TravelerCheckList");
            builder.HasKey(b => b.Id);

            builder
                .Property(t => t.Destination)
                .HasConversion(d => d.ToString(), d => DestinationReadModel.Create(d));

            builder.HasMany(b => b.Items)
                   .WithOne(p => p.TravelerCheckList)
                   ;

        }

        public void Configure(EntityTypeBuilder<TravelerItemReadModel> builder)
        {
            builder.ToTable("TravelerItems");
        }
    }
 
}
