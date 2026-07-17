using Entities;
using Microsoft.EntityFrameworkCore;

namespace database
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Student> Students {get; set;}
        public DbSet<Driver> Drivers {get; set;}
        public DbSet<Administrator> Administrators {get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var student = modelBuilder.Entity<Student>();
            var driver = modelBuilder.Entity<Driver>();
            var administrator = modelBuilder.Entity<Administrator>();

            // Student
            student.Property(s => s.Name).IsRequired().HasMaxLength(100);
            student.Property(s => s.Email).IsRequired().HasMaxLength(150);
            student.Property(s => s.Cpf).IsRequired().HasMaxLength(11);
            student.Property(s => s.Phone).IsRequired().HasMaxLength(20);
            student.Property(s => s.Address).IsRequired().HasMaxLength(255);
            student.Property(s => s.Password).IsRequired();
            student.Property(s => s.RegistrationNumber).IsRequired().HasMaxLength(20);
            student.Property(s => s.University).IsRequired().HasMaxLength(100);
            student.Property(s => s.Course).IsRequired().HasMaxLength(100);

            // Driver
            driver.Property(d => d.Name).IsRequired().HasMaxLength(100);
            driver.Property(d => d.Email).IsRequired().HasMaxLength(150);
            driver.Property(d => d.Cpf).IsRequired().HasMaxLength(11);
            driver.Property(d => d.Phone).IsRequired().HasMaxLength(20);
            driver.Property(d => d.Address).IsRequired().HasMaxLength(255);
            driver.Property(d => d.Password).IsRequired();

            driver.HasOne(d => d.Bus).WithOne(b => b.Driver).HasForeignKey<Bus>(b => b.DriverId);

            driver.HasMany(d => d.Routes).WithOne(r => r.Driver).HasForeignKey(r => r.DriverId);

            driver.Property(d => d.Driverlicense).IsRequired();

            // Administrator
            administrator.Property(a => a.Name).IsRequired().HasMaxLength(100);
            administrator.Property(a => a.Email).IsRequired().HasMaxLength(150);
            administrator.Property(a => a.Cpf).IsRequired().HasMaxLength(11);
            administrator.Property(a => a.Phone).IsRequired().HasMaxLength(20);
            administrator.Property(a => a.Address).IsRequired().HasMaxLength(255);
            administrator.Property(a => a.Password).IsRequired();
        }

    }
}