using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WpfApp17
{
    public partial class ISPr2243_ZobninDS_UPContext : DbContext
    {
        public static ISPr2243_ZobninDS_UPContext instance;
        public static ISPr2243_ZobninDS_UPContext Init()
        {
            if (instance == null)
            {
                instance = new ISPr2243_ZobninDS_UPContext();
            }
            return instance;
        }

        public ISPr2243_ZobninDS_UPContext()
        {
        }

        public ISPr2243_ZobninDS_UPContext(DbContextOptions<ISPr2243_ZobninDS_UPContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Abiturienti> Abiturientis { get; set; } = null!;
        public virtual DbSet<Exam> Exams { get; set; } = null!;
        public virtual DbSet<ExamsBiolog> ExamsBiologs { get; set; } = null!;
        public virtual DbSet<ExamsDesign> ExamsDesigns { get; set; } = null!;
        public virtual DbSet<ExamsIt> ExamsIts { get; set; } = null!;
        public virtual DbSet<Sotrudniki> Sotrudnikis { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySql("server=cfif31.ru;port=3306;userid=ISPr22-43_ZobninDS;database=ISPr22-43_ZobninDS_UP;password=ISPr22-43_ZobninDS", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.32-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("utf8mb4_0900_ai_ci")
                .HasCharSet("utf8mb4");

            modelBuilder.Entity<Abiturienti>(entity =>
            {
                entity.HasKey(e => e.IdAbiturienti)
                    .HasName("PRIMARY");

                entity.ToTable("Abiturienti");

                entity.HasIndex(e => e.Login, "Login_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.ExamsIdExams, "fk_Abiturienti_Exams1_idx");

                entity.Property(e => e.IdAbiturienti)
                    .ValueGeneratedNever()
                    .HasColumnName("idAbiturienti");

                entity.Property(e => e.ExamsIdExams).HasColumnName("Exams_idExams");

                entity.Property(e => e.Familia).HasMaxLength(45);

                entity.Property(e => e.Imya).HasMaxLength(45);

                entity.Property(e => e.Login).HasMaxLength(45);

                entity.Property(e => e.Otchestvo).HasMaxLength(45);

                entity.Property(e => e.Password).HasMaxLength(45);

                entity.Property(e => e.Spec).HasMaxLength(45);

                entity.Property(e => e.Zachislen).HasMaxLength(45);

                entity.HasOne(d => d.ExamsIdExamsNavigation)
                    .WithMany(p => p.Abiturientis)
                    .HasForeignKey(d => d.ExamsIdExams)
                    .HasConstraintName("fk_Abiturienti_Exams1");
            });

            modelBuilder.Entity<Exam>(entity =>
            {
                entity.HasKey(e => e.IdExams)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.ExamsBiologIdExamsBiolog, "fk_Exams_ExamsBiolog_idx");

                entity.HasIndex(e => e.ExamsDesignIdExamsDesign, "fk_Exams_ExamsDesign1_idx");

                entity.HasIndex(e => e.ExamsItIdExamsIt, "fk_Exams_ExamsIT1_idx");

                entity.Property(e => e.IdExams)
                    .ValueGeneratedNever()
                    .HasColumnName("idExams");

                entity.Property(e => e.ExamsBiologIdExamsBiolog).HasColumnName("ExamsBiolog_idExamsBiolog");

                entity.Property(e => e.ExamsDesignIdExamsDesign).HasColumnName("ExamsDesign_idExamsDesign");

                entity.Property(e => e.ExamsItIdExamsIt).HasColumnName("ExamsIT_idExamsIT");

                entity.HasOne(d => d.ExamsBiologIdExamsBiologNavigation)
                    .WithMany(p => p.Exams)
                    .HasForeignKey(d => d.ExamsBiologIdExamsBiolog)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Exams_ExamsBiolog");

                entity.HasOne(d => d.ExamsDesignIdExamsDesignNavigation)
                    .WithMany(p => p.Exams)
                    .HasForeignKey(d => d.ExamsDesignIdExamsDesign)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Exams_ExamsDesign1");

                entity.HasOne(d => d.ExamsItIdExamsItNavigation)
                    .WithMany(p => p.Exams)
                    .HasForeignKey(d => d.ExamsItIdExamsIt)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Exams_ExamsIT1");
            });

            modelBuilder.Entity<ExamsBiolog>(entity =>
            {
                entity.HasKey(e => e.IdExamsBiolog)
                    .HasName("PRIMARY");

                entity.ToTable("ExamsBiolog");

                entity.Property(e => e.IdExamsBiolog)
                    .ValueGeneratedNever()
                    .HasColumnName("idExamsBiolog");

                entity.Property(e => e.Predmet).HasMaxLength(45);
            });

            modelBuilder.Entity<ExamsDesign>(entity =>
            {
                entity.HasKey(e => e.IdExamsDesign)
                    .HasName("PRIMARY");

                entity.ToTable("ExamsDesign");

                entity.Property(e => e.IdExamsDesign)
                    .ValueGeneratedNever()
                    .HasColumnName("idExamsDesign");

                entity.Property(e => e.Predmet).HasMaxLength(45);
            });

            modelBuilder.Entity<ExamsIt>(entity =>
            {
                entity.HasKey(e => e.IdExamsIt)
                    .HasName("PRIMARY");

                entity.ToTable("ExamsIT");

                entity.Property(e => e.IdExamsIt)
                    .ValueGeneratedNever()
                    .HasColumnName("idExamsIT");

                entity.Property(e => e.Predmet).HasMaxLength(45);
            });

            modelBuilder.Entity<Sotrudniki>(entity =>
            {
                entity.HasKey(e => e.IdSotrudniki)
                    .HasName("PRIMARY");

                entity.ToTable("Sotrudniki");

                entity.HasIndex(e => e.Login, "Login_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.IdSotrudniki).HasColumnName("idSotrudniki");

                entity.Property(e => e.Familia).HasMaxLength(45);

                entity.Property(e => e.Imya).HasMaxLength(45);

                entity.Property(e => e.Login).HasMaxLength(45);

                entity.Property(e => e.Otchestvo).HasMaxLength(45);

                entity.Property(e => e.Password).HasMaxLength(45);

                entity.Property(e => e.Role).HasMaxLength(45);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
