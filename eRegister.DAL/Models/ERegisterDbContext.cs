using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace eRegister.DAL.Models;

public partial class ERegisterDbContext : DbContext
{
    public ERegisterDbContext()
    {
    }

    public ERegisterDbContext(DbContextOptions<ERegisterDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Attendance> Attendances { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite("Data Source=../eRegister_DB.db");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Attendance>(entity =>
        {
            entity.ToTable("Attendance");

            entity.Property(e => e.Sin).HasColumnName("SIN");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
