using M4HW3.Entities;
using M4HW3.EntityConfigurations;
using Microsoft.EntityFrameworkCore;

namespace M4HW3.Contexts
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        public DbSet<TitleEntity> Titles { get; set; } = null!;

        public DbSet<OfficeEntity> Offices { get; set; } = null!;

        public DbSet<EmployeeEntity> Employees { get; set; } = null!;

        public DbSet<ProjectEntity> Projects { get; set; } = null!;

        public DbSet<EmployeeProjectEntity> EmployeeProjects { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new TitleEntityConfiguration());
            builder.ApplyConfiguration(new OfficeEntityConfiguration());
            builder.ApplyConfiguration(new EmployeeEntityConfiguration());
            builder.ApplyConfiguration(new ProjectEntityConfiguration());
            builder.ApplyConfiguration(new EmployeeProjectEntityConfiguration());
        }
    }
}
