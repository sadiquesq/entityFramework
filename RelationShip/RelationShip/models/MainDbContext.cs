using Microsoft.EntityFrameworkCore;

namespace RelationShip.models
{
    public class MainDbContext : DbContext
    {
        public MainDbContext(DbContextOptions<MainDbContext> options) : base(options) { }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<EmployeeAddress> employeeAddresses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
           .HasOne(e => e.Address)
           .WithOne(a => a.Employee)
           .HasForeignKey<EmployeeAddress>(a => a.EmployeeId)
           .OnDelete(DeleteBehavior.Cascade);



            modelBuilder.Entity<Employee>()
       .HasOne(e => e.Address)
        .WithOne(e => e.Employee)
        .OnDelete(DeleteBehavior.Cascade);

            //modelBuilder.Entity<Employee>()
            //    .HasOne(e => e.Address)
            //    .WithOne(a => a.Employee)
            //    .OnUpdate()



            //modelBuilder.Entity<EmployeeAddress>()
            //    .HasNoKey();
        }
        //modelBuilder.Entity<Employee>()
        //    .HasOne(e => e.Address)
        //    .WithOne(a => a.)
        //    .HasForeignKey<EmployeeAddress>(a => a.EmployeeId);

      

           

    }
    }
