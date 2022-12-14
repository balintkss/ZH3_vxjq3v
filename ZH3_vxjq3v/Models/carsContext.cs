using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ZH3_vxjq3v.Models;

public partial class carsContext : DbContext
{
    public carsContext()
    {
    }

    public carsContext(DbContextOptions<carsContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Body> Body { get; set; }

    public virtual DbSet<Cars> Cars { get; set; }

    public virtual DbSet<Engine> Engine { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=softeng-database.database.windows.net;Initial Catalog=Cars;Persist Security Info=True;User ID=hallgato;Password=Password123");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Body>(entity =>
        {
            entity.HasKey(e => e.BodyTypeId);

            entity.Property(e => e.BodyTypeId).HasColumnName("Body_type_id");
            entity.Property(e => e.BodyType)
                .HasMaxLength(15)
                .IsFixedLength()
                .HasColumnName("Body_type");
        });

        modelBuilder.Entity<Cars>(entity =>
        {
            entity.Property(e => e.BodyTypeId).HasColumnName("Body_type_id");
            entity.Property(e => e.EngineId).HasColumnName("Engine_id");
            entity.Property(e => e.MaxSpeed).HasColumnName("Max_speed");
            entity.Property(e => e.Model)
                .HasMaxLength(35)
                .IsFixedLength();
            entity.Property(e => e.NumberSeater).HasColumnName("Number_seater");

            entity.HasOne(d => d.BodyType).WithMany(p => p.Cars)
                .HasForeignKey(d => d.BodyTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Body_id");

            entity.HasOne(d => d.Engine).WithMany(p => p.Cars)
                .HasForeignKey(d => d.EngineId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Engine_id");
        });

        modelBuilder.Entity<Engine>(entity =>
        {
            entity.Property(e => e.EngineId).HasColumnName("Engine_id");
            entity.Property(e => e.EngineType)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("Engine_type");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
