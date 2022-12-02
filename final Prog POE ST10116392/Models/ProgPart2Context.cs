using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System;

namespace final_Prog_POE_ST10116392.Models
{
   
    public partial class ProgPart2Context : DbContext
    {
        public ProgPart2Context()
        {
        }

        public ProgPart2Context(DbContextOptions<ProgPart2Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Modules> Modules { get; set; }
        public virtual DbSet<Semester> Semester { get; set; }
        public virtual DbSet<StudyHours> StudyHours { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ProgPart2;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Modules>(entity =>
            {
                entity.HasKey(e => e.ModuleId)
                    .HasName("PK__Modules__1DE5ECA0D8794B2A");

                entity.Property(e => e.ModuleId).HasColumnName("Module_id");

                entity.Property(e => e.Code)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Date1).HasColumnType("date");

                entity.Property(e => e.Name1)
                    .HasMaxLength(55)
                    .IsUnicode(false);

                entity.Property(e => e.SemesterId).HasColumnName("semester_id");

                entity.HasOne(d => d.Semester)
                    .WithMany(p => p.Modules)
                    .HasForeignKey(d => d.SemesterId)
                    .HasConstraintName("FK__Modules__semeste__25869641");
            });

            modelBuilder.Entity<Semester>(entity =>
            {
                entity.ToTable("semester");

                entity.Property(e => e.SemesterId).HasColumnName("semester_id");

                entity.Property(e => e.Date1).HasColumnType("date");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<StudyHours>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("studyHours");

                entity.Property(e => e.Date1).HasColumnType("date");

                entity.Property(e => e.ModuleId).HasColumnName("Module_id");

                entity.HasOne(d => d.Module)
                    .WithMany()
                    .HasForeignKey(d => d.ModuleId)
                    .HasConstraintName("FK__studyHour__Modul__276EDEB3");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__USERS__206A9DF83D0D88FF");

                entity.ToTable("USERS");

                entity.Property(e => e.UserId).HasColumnName("User_id");

                entity.Property(e => e.Password1)
                    .HasMaxLength(55)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}