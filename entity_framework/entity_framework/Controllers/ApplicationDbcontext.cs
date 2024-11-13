using entity_framework.models;
using Microsoft.EntityFrameworkCore;


namespace entity_framework.Controllers
{
    public class ApplicationDbcontext : DbContext
    {

        public ApplicationDbcontext(DbContextOptions<ApplicationDbcontext> options) : base(options)
        {
        }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<books>()
        //        .HasNoKey();
        //}
        public DbSet<books1> Books { get; set; }

        public DbSet<student> students { get; set; }
    }
}
