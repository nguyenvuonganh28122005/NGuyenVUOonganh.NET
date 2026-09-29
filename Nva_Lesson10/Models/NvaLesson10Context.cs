using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Nva_Lesson10.Models;

public partial class NvaLesson10Context : DbContext
{
    public NvaLesson10Context()
    {
    }

    public NvaLesson10Context(DbContextOptions<NvaLesson10Context> options)
        : base(options)
    {
    }

    public virtual DbSet<NvaMember> NvaMembers { get; set; }

    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<NvaMember>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__NvaMembe__3214EC07F53FE63E");

            entity.Property(e => e.TvcEmail)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TvcFullName).HasMaxLength(50);
            entity.Property(e => e.TvcPassword)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TvcPhone)
                .HasMaxLength(12)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TvcUserName)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
