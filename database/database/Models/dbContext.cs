using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace database.Models;

public partial class dbContext : DbContext
{
    public dbContext()
    {
    }

    public dbContext(DbContextOptions<dbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<BOOK> BOOKs { get; set; }

    public virtual DbSet<Books1> Books1s { get; set; }

    public virtual DbSet<EMPLOYEE> EMPLOYEEs { get; set; }

    public virtual DbSet<student> students { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=sadique;database=db;Integrated Security=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Books1>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Books");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
