using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace detghi.Models;

public partial class Net1021FinalllllContext : DbContext
{
    public Net1021FinalllllContext()
    {
    }

    public Net1021FinalllllContext(DbContextOptions<Net1021FinalllllContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Sinhvien> Sinhviens { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=PHUONGVANTRUONG\\PH51152;Database=NET1021_Finalllll;User Id=sa;Password=12345;TrustServerCertificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Sinhvien>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Sinhvien");

            entity.Property(e => e.Gioitinh).HasColumnName("gioitinh");
            entity.Property(e => e.Nganh)
                .HasMaxLength(50)
                .HasColumnName("nganh");
            entity.Property(e => e.Ten)
                .HasMaxLength(50)
                .HasColumnName("ten");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
