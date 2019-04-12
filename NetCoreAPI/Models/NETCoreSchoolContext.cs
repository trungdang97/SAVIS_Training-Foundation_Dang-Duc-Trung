using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace NetCoreAPI_DataFirst.Models
{
    public partial class NETCoreSchoolContext : DbContext
    {
        public NETCoreSchoolContext()
        {
        }

        public NETCoreSchoolContext(DbContextOptions<NETCoreSchoolContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Classes> Classes { get; set; }
        public virtual DbSet<Students> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=.\\SQLEXPRESS;Initial Catalog=NET.Core.School;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Classes>(entity =>
            {
                entity.HasKey(e => e.IntId);

                entity.Property(e => e.IntId).HasColumnName("intId");

                entity.Property(e => e.IntAcademicYear).HasColumnName("intAcademicYear");

                entity.Property(e => e.IntQuantity).HasColumnName("intQuantity");

                entity.Property(e => e.StrCode).HasColumnName("strCode");

                entity.Property(e => e.StrName).HasColumnName("strName");
            });

            modelBuilder.Entity<Students>(entity =>
            {
                entity.HasKey(e => e.IntId);

                entity.HasIndex(e => e.ClassId);

                entity.Property(e => e.IntId).HasColumnName("intId");

                entity.Property(e => e.ClassId).HasColumnName("Class_Id");

                entity.Property(e => e.DateBirth).HasColumnName("dateBirth");

                entity.Property(e => e.StrCode).HasColumnName("strCode");

                entity.Property(e => e.StrName).HasColumnName("strName");

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.ClassId);
            });
        }
    }
}
