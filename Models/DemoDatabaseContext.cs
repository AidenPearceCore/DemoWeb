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

        public virtual DbSet<House> Houses { get; set; } = null!;


        //資料庫使用SQL Server
        #region
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //TODO: 字串待轉移到appsettings.json
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=DemoDatabase;Trusted_Connection=True;User ID=demo;Password=demo");
            }
        }
        #endregion


        // 物件對應關聯使用EntityFrameworkCore框架
        // 資料庫存取使用lambda陳述式, LINQ查詢
        #region
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
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

                entity.Property(e => e.Type)
                    .HasMaxLength(10)
                    .HasColumnName("type")
                    .IsFixedLength();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
        #endregion
    }
}
