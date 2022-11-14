using M4HW3.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace M4HW3.EntityConfigurations
{
    public class EmployeeProjectEntityConfiguration : IEntityTypeConfiguration<EmployeeProjectEntity>
    {
        public void Configure(EntityTypeBuilder<EmployeeProjectEntity> builder)
        {
            builder.ToTable("EmployeeProject").HasKey(p => p.Id);
            builder.Property(p => p.Rate).HasColumnType("money");
        }
    }
}
