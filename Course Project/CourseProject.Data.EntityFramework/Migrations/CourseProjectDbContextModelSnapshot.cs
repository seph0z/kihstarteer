﻿// <auto-generated />
using System;
using CourseProject.Data.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CourseProject.Data.EntityFramework.Migrations
{
    [DbContext(typeof(CourseProjectDbContext))]
    partial class CourseProjectDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CourseProject.Data.Contracts.Entities.AspNetRoleClaims", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("CourseProject.Data.Contracts.Entities.AspNetRoles", b =>
                {
                    b.Property<string>("Id");

                    b.Property<string>("ConcurrencyStamp");

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("([NormalizedName] IS NOT NULL)");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("CourseProject.Data.Contracts.Entities.AspNetUserClaims", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("CourseProject.Data.Contracts.Entities.AspNetUserLogins", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("CourseProject.Data.Contracts.Entities.AspNetUserRoles", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("CourseProject.Data.Contracts.Entities.AspNetUserTokens", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasMaxLength(128);

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("CourseProject.Data.Contracts.Entities.AspNetUsers", b =>
                {
                    b.Property<string>("Id");

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("Biography");

                    b.Property<string>("ConcurrencyStamp");

                    b.Property<string>("Country");

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("Image");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("([NormalizedUserName] IS NOT NULL)");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("CourseProject.Data.Contracts.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Section");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Section = "Art"
                        },
                        new
                        {
                            Id = 2,
                            Section = "Comics"
                        },
                        new
                        {
                            Id = 3,
                            Section = "Crafts"
                        },
                        new
                        {
                            Id = 4,
                            Section = "Dance"
                        },
                        new
                        {
                            Id = 5,
                            Section = "Design"
                        },
                        new
                        {
                            Id = 6,
                            Section = "Fashion"
                        },
                        new
                        {
                            Id = 7,
                            Section = "Film & Video"
                        },
                        new
                        {
                            Id = 8,
                            Section = "Food"
                        },
                        new
                        {
                            Id = 9,
                            Section = "Games"
                        },
                        new
                        {
                            Id = 10,
                            Section = "Journalism"
                        },
                        new
                        {
                            Id = 11,
                            Section = "Music"
                        },
                        new
                        {
                            Id = 12,
                            Section = "Photography"
                        },
                        new
                        {
                            Id = 13,
                            Section = "Publishing"
                        },
                        new
                        {
                            Id = 14,
                            Section = "Technology"
                        },
                        new
                        {
                            Id = 15,
                            Section = "Theater"
                        });
                });

            modelBuilder.Entity("CourseProject.Data.Contracts.Entities.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Create");

                    b.Property<int>("ProjectId");

                    b.Property<string>("Text");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.HasIndex("UserId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("CourseProject.Data.Contracts.Entities.Content", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ProjectId");

                    b.Property<string>("Text");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId")
                        .IsUnique();

                    b.ToTable("Contents");
                });

            modelBuilder.Entity("CourseProject.Data.Contracts.Entities.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Path");

                    b.Property<int>("ProjectId");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.ToTable("Image");
                });

            modelBuilder.Entity("CourseProject.Data.Contracts.Entities.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content");

                    b.Property<int>("ProjectId");

                    b.Property<string>("SubTitle");

                    b.Property<string>("Title");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.HasIndex("UserId");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("CourseProject.Data.Contracts.Entities.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId");

                    b.Property<double>("CurrentFunding");

                    b.Property<DateTime>("Duration");

                    b.Property<double>("Funding");

                    b.Property<string>("Image");

                    b.Property<string>("Subtitle");

                    b.Property<string>("Title");

                    b.Property<string>("UserId");

                    b.Property<string>("Video");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("UserId");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("CourseProject.Data.Contracts.Entities.ProjectTag", b =>
                {
                    b.Property<int>("ProjectId");

                    b.Property<int>("TagId");

                    b.HasKey("ProjectId", "TagId");

                    b.HasIndex("TagId");

                    b.ToTable("ProjectTags");
                });

            modelBuilder.Entity("CourseProject.Data.Contracts.Entities.Reward", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount");

                    b.Property<string>("Description");

                    b.Property<int>("ProjectId");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.ToTable("Rewards");
                });

            modelBuilder.Entity("CourseProject.Data.Contracts.Entities.RewardAspNetUsers", b =>
                {
                    b.Property<int>("RewardId");

                    b.Property<string>("UserId");

                    b.HasKey("RewardId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("RewardAspNetUsers");
                });

            modelBuilder.Entity("CourseProject.Data.Contracts.Entities.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Text");

                    b.HasKey("Id");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("CourseProject.Data.Contracts.Entities.AspNetRoleClaims", b =>
                {
                    b.HasOne("CourseProject.Data.Contracts.Entities.AspNetRoles", "Role")
                        .WithMany("AspNetRoleClaims")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CourseProject.Data.Contracts.Entities.AspNetUserClaims", b =>
                {
                    b.HasOne("CourseProject.Data.Contracts.Entities.AspNetUsers", "User")
                        .WithMany("AspNetUserClaims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CourseProject.Data.Contracts.Entities.AspNetUserLogins", b =>
                {
                    b.HasOne("CourseProject.Data.Contracts.Entities.AspNetUsers", "User")
                        .WithMany("AspNetUserLogins")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CourseProject.Data.Contracts.Entities.AspNetUserRoles", b =>
                {
                    b.HasOne("CourseProject.Data.Contracts.Entities.AspNetRoles", "Role")
                        .WithMany("AspNetUserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CourseProject.Data.Contracts.Entities.AspNetUsers", "User")
                        .WithMany("AspNetUserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CourseProject.Data.Contracts.Entities.AspNetUserTokens", b =>
                {
                    b.HasOne("CourseProject.Data.Contracts.Entities.AspNetUsers", "User")
                        .WithMany("AspNetUserTokens")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CourseProject.Data.Contracts.Entities.Comment", b =>
                {
                    b.HasOne("CourseProject.Data.Contracts.Entities.Project", "Project")
                        .WithMany("Comments")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CourseProject.Data.Contracts.Entities.AspNetUsers", "User")
                        .WithMany("Comments")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("CourseProject.Data.Contracts.Entities.Content", b =>
                {
                    b.HasOne("CourseProject.Data.Contracts.Entities.Project", "Project")
                        .WithOne("Content")
                        .HasForeignKey("CourseProject.Data.Contracts.Entities.Content", "ProjectId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CourseProject.Data.Contracts.Entities.Image", b =>
                {
                    b.HasOne("CourseProject.Data.Contracts.Entities.Project", "Project")
                        .WithMany("Images")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CourseProject.Data.Contracts.Entities.Post", b =>
                {
                    b.HasOne("CourseProject.Data.Contracts.Entities.Project", "Project")
                        .WithMany("Posts")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CourseProject.Data.Contracts.Entities.AspNetUsers", "User")
                        .WithMany("Posts")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("CourseProject.Data.Contracts.Entities.Project", b =>
                {
                    b.HasOne("CourseProject.Data.Contracts.Entities.Category", "Category")
                        .WithMany("Projects")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CourseProject.Data.Contracts.Entities.AspNetUsers", "User")
                        .WithMany("Projects")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("CourseProject.Data.Contracts.Entities.ProjectTag", b =>
                {
                    b.HasOne("CourseProject.Data.Contracts.Entities.Project", "Project")
                        .WithMany("ProjectTags")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CourseProject.Data.Contracts.Entities.Tag", "Tag")
                        .WithMany("ProjectTags")
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CourseProject.Data.Contracts.Entities.Reward", b =>
                {
                    b.HasOne("CourseProject.Data.Contracts.Entities.Project", "Project")
                        .WithMany("Rewards")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CourseProject.Data.Contracts.Entities.RewardAspNetUsers", b =>
                {
                    b.HasOne("CourseProject.Data.Contracts.Entities.Reward", "Reward")
                        .WithMany("RewardAspNetUsers")
                        .HasForeignKey("RewardId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CourseProject.Data.Contracts.Entities.AspNetUsers", "User")
                        .WithMany("RewardAspNetUsers")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
