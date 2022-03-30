using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DemoWeb.Models
{
    public partial class DemoDatabaseContext : DbContext
    {
        public DemoDatabaseContext()
        {
        }

        public DemoDatabaseContext(DbContextOptions<DemoDatabaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Company> Companies { get; set; } = null!;
        public virtual DbSet<Customer> Customers { get; set; } = null!;
        public virtual DbSet<House> Houses { get; set; } = null!;
        public virtual DbSet<Uploadfile> Uploadfiles { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
         
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Company>(entity =>
            {
                entity.ToTable("company");

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .HasColumnName("id")
                    .IsFixedLength();

                entity.Property(e => e.Address).HasColumnName("address");

                entity.Property(e => e.Contect).HasColumnName("contect");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.Tel)
                    .HasMaxLength(50)
                    .HasColumnName("tel");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("customer");

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .HasColumnName("id")
                    .IsFixedLength();

                entity.Property(e => e.City).HasColumnName("city");

                entity.Property(e => e.Company).HasColumnName("company");

                entity.Property(e => e.Email).HasColumnName("email");

                entity.Property(e => e.Gender)
                    .HasMaxLength(50)
                    .HasColumnName("gender");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .HasColumnName("phone");

                entity.Property(e => e.Street).HasColumnName("street");

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.Customer)
                    .HasForeignKey<Customer>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_customer_company1");
            });

            modelBuilder.Entity<House>(entity =>
            {
                entity.ToTable("house");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.City).HasColumnName("city");

                entity.Property(e => e.Estatename).HasColumnName("estatename");

                entity.Property(e => e.Floor)
                    .HasMaxLength(10)
                    .HasColumnName("floor")
                    .IsFixedLength();

                entity.Property(e => e.Numberofrooms).HasColumnName("numberofrooms");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.Type)
                    .HasMaxLength(10)
                    .HasColumnName("type")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Uploadfile>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("uploadfile");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
