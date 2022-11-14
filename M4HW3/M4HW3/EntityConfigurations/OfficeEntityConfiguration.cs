using M4HW3.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace M4HW3.EntityConfigurations
{
    public class OfficeEntityConfiguration : IEntityTypeConfiguration<OfficeEntity>
    {
        public void Configure(EntityTypeBuilder<OfficeEntity> builder)
        {
            builder.ToTable("Office").HasKey(p => p.Id);
            builder.Property(p => p.Title).HasMaxLength(100);
            builder.Property(p => p.Location).HasMaxLength(100);
        }
    }
}
