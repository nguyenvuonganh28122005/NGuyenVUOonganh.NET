using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NVA_2410900004_Exam.Models;

public partial class NguyenVuongAnhStudentContext : DbContext
{
    public NguyenVuongAnhStudentContext()
    {
    }

    public NguyenVuongAnhStudentContext(DbContextOptions<NguyenVuongAnhStudentContext> options)
        : base(options)
    {
    }

    public virtual DbSet<NguyenVuongAnhStudent> NguyenVuongAnhStudents { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<NguyenVuongAnhStudent>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__NguyenVu__3214EC078350273D");

            entity.ToTable("NguyenVuongAnhStudent");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.NguyenVuongAnhEmail).HasMaxLength(100);
            entity.Property(e => e.NguyenVuongAnhName).HasMaxLength(50);
            entity.Property(e => e.NguyenVuongAnhPhone)
                .HasMaxLength(12)
                .IsUnicode(false)
                .IsFixedLength();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
