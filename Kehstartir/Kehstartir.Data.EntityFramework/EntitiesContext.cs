using System;
using Kehstartir.Data.Contracts.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Kehstartir.Data.EntityFramework
{
    public partial class EntitiesContext : DbContext
    {
        public EntitiesContext()
        {
        }

        public EntitiesContext(DbContextOptions<EntitiesContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AspNetRoleClaims> AspNetRoleClaims { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUserTokens> AspNetUserTokens { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }

        public virtual DbSet<Profile> Profiles { get; set; }
        public virtual DbSet<Campaign> Campaigns { get; set; }
        public virtual DbSet<CampaignTag> CampaignTags { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<Image> Images { get; set; }
        public virtual DbSet<Bonus> Bonuses { get; set; }
        public virtual DbSet<BonusAspNetUsers> BonusAspNetUsers { get; set; }
        public virtual DbSet<BonusCampaign> BonusCampaigns { get; set; }
        public virtual DbSet<Post> Posts { get; set; }
        public virtual DbSet<Rating> Ratings { get; set; }
        public virtual DbSet<RatingAspNetUsers> RatingAspNetUsers { get; set; }
        public virtual DbSet<Like> Likes { get; set; }
        public virtual DbSet<LikeAspNetUsers> LikeAspNetUsers { get; set; }
        public virtual DbSet<Theme> Themes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseLazyLoadingProxies().UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=Kehstartir;Trusted_Connection=True;");
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

            modelBuilder.Entity<Profile>(entity =>
            {
                entity.HasOne(d => d.User)
                .WithOne(p => p.Profile)
                .HasForeignKey<Profile>(d => d.UserId);
            });

            modelBuilder.Entity<Campaign>(entity =>
            {
                entity.HasOne(d => d.User)
                .WithMany(p => p.Campaigns)
                .HasForeignKey(d => d.UserId);

                entity.HasOne(d => d.Rating)
                .WithOne(p => p.Campaign)
                .HasForeignKey<Rating>(d => d.CampaignId);

                entity.HasOne(d => d.Theme)
                .WithMany(p => p.Campaigns)
                .HasForeignKey(d => d.ThemeId);
            });

            modelBuilder.Entity<CampaignTag>(entity =>
            {
                entity.HasKey(sc => new { sc.CampaignId, sc.TagId });

                entity.HasOne(d => d.Campaign)
                .WithMany(p => p.CampaignTags)
                .HasForeignKey(d => d.CampaignId);

                entity.HasOne(d => d.Tag)
                .WithMany(p => p.CampaignTags)
                .HasForeignKey(d => d.TagId);
            });

            modelBuilder.Entity<Comment>(entity =>
            {
                entity.HasOne(d => d.Campaign)
                .WithMany(p => p.Comments)
                .HasForeignKey(d => d.CampaignId);

                entity.HasOne(d => d.User)
                .WithMany(p => p.Comments)
                .HasForeignKey(d => d.UserId);

                entity.HasOne(d => d.Like)
                .WithOne(p => p.Comment)
                .HasForeignKey<Like>(d => d.CommentId);
            });

            modelBuilder.Entity<Image>(entity =>
            {
                entity.HasOne(d => d.Campaign)
                .WithMany(p => p.Images)
                .HasForeignKey(d => d.CampaignId);
            });

            modelBuilder.Entity<BonusCampaign>(entity =>
            {
                entity.HasKey(sc => new { sc.BonusId, sc.CampaignId });

                entity.HasOne(d => d.Bonus)
                .WithMany(p => p.BonusCampaigns)
                .HasForeignKey(d => d.BonusId);

                entity.HasOne(d => d.Campaign)
                .WithMany(p => p.BonusCampaigns)
                .HasForeignKey(d => d.CampaignId);
            });

            modelBuilder.Entity<BonusAspNetUsers>(entity =>
            {
                entity.HasKey(sc => new { sc.BonusId, sc.UserId });

                entity.HasOne(d => d.Bonus)
                .WithMany(p => p.BonusAspNetUsers)
                .HasForeignKey(d => d.BonusId);

                entity.HasOne(d => d.User)
                .WithMany(p => p.BonusAspNetUsers)
                .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<Post>(entity =>
            {
                entity.HasOne(d => d.Campaign)
                .WithMany(p => p.Posts)
                .HasForeignKey(d => d.CampaignId);

                entity.HasOne(d => d.User)
                .WithMany(p => p.Posts)
                .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<RatingAspNetUsers>(entity =>
            {
                entity.HasKey(sc => new { sc.RatingId, sc.UserId });

                entity.HasOne(d => d.Rating)
                .WithMany(p => p.RatingAspNetUsers)
                .HasForeignKey(d => d.RatingId);

                entity.HasOne(d => d.User)
                .WithMany(p => p.RatingAspNetUsers)
                .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<LikeAspNetUsers>(entity =>
            {
                entity.HasKey(sc => new { sc.LikeId, sc.UserId });

                entity.HasOne(d => d.Like)
                .WithMany(p => p.LikeAspNetUsers)
                .HasForeignKey(d => d.LikeId);

                entity.HasOne(d => d.User)
                .WithMany(p => p.LikeAspNetUsers)
                .HasForeignKey(d => d.UserId);
            });
        }
    }
}
