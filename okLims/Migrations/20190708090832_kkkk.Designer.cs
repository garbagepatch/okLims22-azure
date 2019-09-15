﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using okLims.Data;
using System;

namespace okLims.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20190708090832_kkkk")]
    partial class kkkk
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("okLims.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

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
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("okLims.Models.ControllerType", b =>
                {
                    b.Property<int>("ControllerID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("controllerType");

                    b.HasKey("ControllerID");

                    b.ToTable("ControllerType");
                });

            modelBuilder.Entity("okLims.Models.FilterSize", b =>
                {
                    b.Property<int>("SizeID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("filterSize");

                    b.HasKey("SizeID");

                    b.ToTable("FilterSize");
                });

            modelBuilder.Entity("okLims.Models.FilterType", b =>
                {
                    b.Property<int>("FilterID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("filterType");

                    b.HasKey("FilterID");

                    b.ToTable("FilterType");
                });

            modelBuilder.Entity("okLims.Models.Instrument", b =>
                {
                    b.Property<int>("InstrumentId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTimeOffset>("CalibrationDate");

                    b.Property<DateTimeOffset>("CalibrationDue");

                    b.Property<int>("CalibrationLength");

                    b.Property<string>("InstrumentName")
                        .IsRequired();

                    b.Property<DateTime>("MaintenanceDate");

                    b.Property<int>("MaintenanceInterval");

                    b.HasKey("InstrumentId");

                    b.ToTable("Instrument");
                });

            modelBuilder.Entity("okLims.Models.Laboratory", b =>
                {
                    b.Property<int>("LaboratoryId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("LaboratoryName")
                        .IsRequired();

                    b.HasKey("LaboratoryId");

                    b.ToTable("Laboratory");
                });

            modelBuilder.Entity("okLims.Models.NumberSequence", b =>
                {
                    b.Property<int>("NumberSequenceId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("LastNumber");

                    b.Property<string>("Module")
                        .IsRequired();

                    b.Property<string>("NumberSequenceName")
                        .IsRequired();

                    b.Property<string>("Prefix")
                        .IsRequired();

                    b.HasKey("NumberSequenceId");

                    b.ToTable("NumberSequence");
                });

            modelBuilder.Entity("okLims.Models.Request", b =>
                {
                    b.Property<int>("RequestId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ControllerID");

                    b.Property<string>("End")
                        .IsRequired();

                    b.Property<int>("FilterID");

                    b.Property<int?>("LaboratoryId");

                    b.Property<string>("RequesterEmail");

                    b.Property<int>("SizeID");

                    b.Property<string>("SpecialDetails");

                    b.Property<string>("Start")
                        .IsRequired();

                    b.HasKey("RequestId");

                    b.HasIndex("ControllerID");

                    b.HasIndex("FilterID");

                    b.HasIndex("LaboratoryId");

                    b.HasIndex("SizeID");

                    b.ToTable("Request");
                });

            modelBuilder.Entity("okLims.Models.RequestLine", b =>
                {
                    b.Property<int>("RequestLineId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DateCompleted");

                    b.Property<string>("End");

                    b.Property<int>("RequestId");

                    b.Property<string>("Start");

                    b.HasKey("RequestLineId");

                    b.HasIndex("RequestId");

                    b.ToTable("RequestLine");
                });

            modelBuilder.Entity("okLims.Models.UserProfile", b =>
                {
                    b.Property<int>("UserProfileId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ApplicationUserId");

                    b.Property<string>("ConfirmPassword");

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("OldPassword");

                    b.Property<string>("Password");

                    b.HasKey("UserProfileId");

                    b.ToTable("UserProfile");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("okLims.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("okLims.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("okLims.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("okLims.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("okLims.Models.Request", b =>
                {
                    b.HasOne("okLims.Models.ControllerType", "ControllerType")
                        .WithMany()
                        .HasForeignKey("ControllerID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("okLims.Models.FilterType", "FilterType")
                        .WithMany()
                        .HasForeignKey("FilterID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("okLims.Models.Laboratory", "Laboratory")
                        .WithMany()
                        .HasForeignKey("LaboratoryId");

                    b.HasOne("okLims.Models.FilterSize", "FilterSize")
                        .WithMany()
                        .HasForeignKey("SizeID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("okLims.Models.RequestLine", b =>
                {
                    b.HasOne("okLims.Models.Request", "Request")
                        .WithMany("RequestLines")
                        .HasForeignKey("RequestId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
