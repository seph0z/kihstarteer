using CourseProject.Data.Contracts.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace CourseProject.Data.EntityFramework
{
    public partial class CourseProjectDbContext : DbContext
    {
        public CourseProjectDbContext()
        {
        }

        public CourseProjectDbContext(DbContextOptions<CourseProjectDbContext> options)
            : base(options)
        {
        }

        public DbSet<AspNetRoleClaims> AspNetRoleClaims { get; set; }
        public DbSet<AspNetRoles> AspNetRoles { get; set; }
        public DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }
        public DbSet<AspNetUserTokens> AspNetUserTokens { get; set; }
        public DbSet<AspNetUsers> AspNetUsers { get; set; }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Content> Contents { get; set; }
        public DbSet<Reward> Rewards { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<ProjectTag> ProjectTags { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                    .UseLazyLoadingProxies()
                    .UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=CourseProject;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity<AspNetRoleClaims>(entity =>
            {
                entity.HasIndex(e => e.RoleId);

                entity.Property(e => e.RoleId).IsRequired();

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetRoleClaims)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<AspNetRoles>(entity =>
            {
                entity.HasIndex(e => e.NormalizedName)
                    .HasName("RoleNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedName] IS NOT NULL)");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserClaims>(entity =>
            {
                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserLogins>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.ProviderKey).HasMaxLength(128);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserRoles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });

                entity.HasIndex(e => e.RoleId);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.RoleId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserTokens>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.Name).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserTokens)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUsers>(entity =>
            {
                entity.HasIndex(e => e.NormalizedEmail)
                    .HasName("EmailIndex");

                entity.HasIndex(e => e.NormalizedUserName)
                    .HasName("UserNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedUserName] IS NOT NULL)");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.UserName).HasMaxLength(256);
            });

            modelBuilder.Entity<Project>(entity =>
            {
                entity.HasOne(d => d.Category)
                .WithMany(p => p.Projects)
                .HasForeignKey(d => d.CategoryId);

                entity.HasOne(d => d.User)
                .WithMany(p => p.Projects)
                .HasForeignKey(d => d.UserId);

                entity.HasMany(d => d.Images)
                .WithOne(p => p.Project)
                .HasForeignKey(d => d.ProjectId);
            });

            modelBuilder.Entity<ProjectTag>(entity =>
            {
                entity.HasKey(sc => new { sc.ProjectId, sc.TagId });

                entity.HasOne(d => d.Project)
                .WithMany(p => p.ProjectTags)
                .HasForeignKey(d => d.ProjectId);

                entity.HasOne(d => d.Tag)
                .WithMany(p => p.ProjectTags)
                .HasForeignKey(d => d.TagId);
            });

            modelBuilder.Entity<Category>().HasData(new List<Category>
            {
                new Category { Id = 1, Section = "Art"},
                new Category { Id = 2,Section = "Comics"},
                new Category { Id = 3,Section = "Crafts"},
                new Category { Id = 4,Section = "Dance"},
                new Category { Id = 5,Section = "Design"},
                new Category { Id = 6,Section = "Fashion"},
                new Category { Id = 7,Section = "Film & Video"},
                new Category { Id = 8,Section = "Food"},
                new Category { Id = 9,Section = "Games"},
                new Category { Id = 10,Section = "Journalism"},
                new Category { Id = 11,Section = "Music"},
                new Category { Id = 12,Section = "Photography"},
                new Category { Id = 13,Section = "Publishing"},
                new Category { Id = 14,Section = "Technology"},
                new Category { Id = 15,Section = "Theater"}
            });
        }
    }
}
