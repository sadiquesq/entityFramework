using MainEntityFramework.Models;
using Microsoft.EntityFrameworkCore;

namespace MainEntityFramework.Controllers
{
    public class MainDbContext : DbContext
    {

        public MainDbContext(DbContextOptions<MainDbContext> options) : base(options) { }


        public DbSet<Models.Employee> Employees { get; set; }

        public DbSet<employeeAddress> EmployeeAddresses { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<employeeAddress>().HasKey(e => e.AddressId);


            modelBuilder.Entity<Employee>()
                .HasOne(e => e.employeeAddress)
                .WithOne(e => e.employee)
                .HasForeignKey<Employee>(e => e.AddressId);
        }

    }
}
