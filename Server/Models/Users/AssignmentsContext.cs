using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace AssignmentDashboard.Server.Models.Users
{
    public partial class AssignmentsContext : DbContext
    {
        public AssignmentsContext()
        {
        }

        public AssignmentsContext(DbContextOptions<AssignmentsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserLoginAttempt> UserLoginAttempts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Name=AssignmentDashboard");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Cyrillic_General_CI_AS");

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("User");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.ListAttempt)
                    .IsRequired()
                    .HasColumnName("List_attempt");

                entity.Property(e => e.Name).HasMaxLength(30);

                entity.Property(e => e.Surname).HasMaxLength(30);
            });

            modelBuilder.Entity<UserLoginAttempt>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("UserLoginAttempt");

                entity.Property(e => e.AttemptTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Attempt_time");

                entity.Property(e => e.ListUserId)
                    .IsRequired()
                    .HasColumnName("list_user_id");

                entity.HasOne(d => d.ListUserIdNavigation)
                    .WithMany(p => p.UserLoginAttempts)
                    .HasForeignKey(d => d.ListUserId)
                    .HasConstraintName("FK__UserLoginAttempt__list_user_id__5EBF139D");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
