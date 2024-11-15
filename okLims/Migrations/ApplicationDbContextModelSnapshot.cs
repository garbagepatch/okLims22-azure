﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using okLims.Data;

namespace okLims.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
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

                    b.Property<string>("ApplicationUserId");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("ConfirmPassword");

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("OldPassword");

                    b.Property<string>("Password");

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("ProfilePicture");

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
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("RequestFK");

                    b.Property<string>("controllerType");

                    b.HasKey("ControllerID");

                    b.ToTable("ControllerType");
                });

            modelBuilder.Entity("okLims.Models.FilterSize", b =>
                {
                    b.Property<int>("SizeID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("RequestFK");

                    b.Property<string>("filterSize");

                    b.HasKey("SizeID");

                    b.ToTable("FilterSize");
                });

            modelBuilder.Entity("okLims.Models.FilterType", b =>
                {
                    b.Property<int>("FilterID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("RequestFK");

                    b.Property<string>("filterType");

                    b.HasKey("FilterID");

                    b.ToTable("FilterType");
                });

            modelBuilder.Entity("okLims.Models.Instrument", b =>
                {
                    b.Property<int>("InstrumentId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CalibrationDate");

                    b.Property<DateTime>("CalibrationDue");

                    b.Property<int>("CalibrationLength");

                    b.Property<int?>("InstrumentFK");

                    b.Property<string>("InstrumentName")
                        .IsRequired();

                    b.Property<int>("InstrumentTypeID");

                    b.Property<DateTime>("MaintenanceDate");

                    b.Property<DateTime>("MaintenanceDue");

                    b.Property<int>("MaintenanceInterval");

                    b.HasKey("InstrumentId");

                    b.HasIndex("InstrumentFK");

                    b.HasIndex("InstrumentTypeID");

                    b.ToTable("Instrument");
                });

            modelBuilder.Entity("okLims.Models.InstrumentLine", b =>
                {
                    b.Property<int>("InstrumentLineId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTimeOffset>("CalibrationDate");

                    b.Property<DateTimeOffset>("CalibrationDue");

                    b.Property<int>("CalibrationLength");

                    b.Property<string>("InstrumentHistory");

                    b.Property<int>("InstrumentId");

                    b.Property<string>("InstrumentName");

                    b.Property<DateTime>("MaintenanceDate");

                    b.Property<int>("MaintenanceInterval");

                    b.HasKey("InstrumentLineId");

                    b.HasIndex("InstrumentId");

                    b.ToTable("InstrumentLine");
                });

            modelBuilder.Entity("okLims.Models.InstrumentType", b =>
                {
                    b.Property<int>("InstrumentTypeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("InstrumentFK");

                    b.Property<string>("instrumentType");

                    b.HasKey("InstrumentTypeId");

                    b.ToTable("InstrumentType");
                });

            modelBuilder.Entity("okLims.Models.Laboratory", b =>
                {
                    b.Property<int>("LaboratoryId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LaboratoryName");

                    b.Property<int>("RequestFK");

                    b.HasKey("LaboratoryId");

                    b.ToTable("Laboratory");
                });

            modelBuilder.Entity("okLims.Models.NumberSequence", b =>
                {
                    b.Property<int>("NumberSequenceId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ControllerID");

                    b.Property<string>("Description");

                    b.Property<DateTime>("End");

                    b.Property<int>("EventFK");

                    b.Property<int>("FilterID");

                    b.Property<int>("LaboratoryId");

                    b.Property<string>("RequesterEmail");

                    b.Property<int?>("ScheduleEventId");

                    b.Property<int>("SizeID");

                    b.Property<string>("SpecialDetails");

                    b.Property<DateTime>("Start");

                    b.Property<int>("StateId");

                    b.Property<string>("Subject");

                    b.HasKey("RequestId");

                    b.HasIndex("ControllerID");

                    b.HasIndex("FilterID");

                    b.HasIndex("LaboratoryId");

                    b.HasIndex("ScheduleEventId");

                    b.HasIndex("SizeID");

                    b.HasIndex("StateId");

                    b.ToTable("Request");
                });

            modelBuilder.Entity("okLims.Models.RequestLine", b =>
                {
                    b.Property<int>("RequestLineId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ControllerID");

                    b.Property<string>("End");

                    b.Property<int>("FilterID");

                    b.Property<int>("LaboratoryId");

                    b.Property<int>("RequestId");

                    b.Property<string>("RequesterEmail");

                    b.Property<int>("SizeID");

                    b.Property<string>("SpecialDetails");

                    b.Property<string>("Start");

                    b.HasKey("RequestLineId");

                    b.HasIndex("RequestId");

                    b.ToTable("RequestLine");
                });

            modelBuilder.Entity("okLims.Models.RequestState", b =>
                {
                    b.Property<int>("StateId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("State");

                    b.HasKey("StateId");

                    b.ToTable("RequestState");
                });

            modelBuilder.Entity("okLims.Models.ScheduleEvent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool?>("AllDay");

                    b.Property<string>("CategoryColor");

                    b.Property<string>("Description");

                    b.Property<DateTime>("EndTime");

                    b.Property<string>("Location");

                    b.Property<DateTime>("StartTime");

                    b.Property<int>("StateId");

                    b.Property<string>("Subject");

                    b.HasKey("Id");

                    b.HasIndex("StateId");

                    b.ToTable("ScheduleEvent");
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

            modelBuilder.Entity("okLims.Models.Instrument", b =>
                {
                    b.HasOne("okLims.Models.InstrumentType")
                        .WithMany("Instrument")
                        .HasForeignKey("InstrumentFK");

                    b.HasOne("okLims.Models.InstrumentType", "InstrumentType")
                        .WithMany()
                        .HasForeignKey("InstrumentTypeID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("okLims.Models.InstrumentLine", b =>
                {
                    b.HasOne("okLims.Models.Instrument", "Instrument")
                        .WithMany("InstrumentLines")
                        .HasForeignKey("InstrumentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("okLims.Models.Request", b =>
                {
                    b.HasOne("okLims.Models.ControllerType", "ControllerType")
                        .WithMany("Requests")
                        .HasForeignKey("ControllerID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("okLims.Models.FilterType", "FilterType")
                        .WithMany("Requests")
                        .HasForeignKey("FilterID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("okLims.Models.Laboratory", "Laboratory")
                        .WithMany("Requests")
                        .HasForeignKey("LaboratoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("okLims.Models.ScheduleEvent", "ScheduleEvent")
                        .WithMany()
                        .HasForeignKey("ScheduleEventId");

                    b.HasOne("okLims.Models.FilterSize", "FilterSize")
                        .WithMany("Requests")
                        .HasForeignKey("SizeID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("okLims.Models.RequestState", "State")
                        .WithMany("Request")
                        .HasForeignKey("StateId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("okLims.Models.RequestLine", b =>
                {
                    b.HasOne("okLims.Models.Request", "Request")
                        .WithMany("RequestLines")
                        .HasForeignKey("RequestId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("okLims.Models.ScheduleEvent", b =>
                {
                    b.HasOne("okLims.Models.RequestState", "Status")
                        .WithMany()
                        .HasForeignKey("StateId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
