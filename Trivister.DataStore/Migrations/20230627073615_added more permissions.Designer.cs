﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Trivister.DataStore.Context;

#nullable disable

namespace Trivister.DataStore.Migrations
{
    [DbContext(typeof(IdpDbContext))]
    [Migration("20230627073615_added more permissions")]
    partial class addedmorepermissions
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUserRole<Guid>");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Trivister.Core.Entities.ApplicationRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(400)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("3e7d9440-48d7-4174-b9c5-0ea5be7d9e7d"),
                            ConcurrencyStamp = "79ac1549-2cc2-4c85-852d-14f9a7f09e44",
                            CreatedOn = new DateTime(2023, 6, 27, 7, 36, 15, 174, DateTimeKind.Utc).AddTicks(7440),
                            Description = "",
                            IsDeleted = false,
                            LastModified = new DateTime(2023, 6, 27, 7, 36, 15, 174, DateTimeKind.Utc).AddTicks(7440),
                            Name = "SuperAdmin",
                            NormalizedName = "SUPERADMIN"
                        },
                        new
                        {
                            Id = new Guid("0834d4fc-a976-4428-b6f8-d47b832fad1a"),
                            ConcurrencyStamp = "a326a8ba-08bc-458e-89b7-f8a6234878ed",
                            CreatedOn = new DateTime(2023, 6, 27, 7, 36, 15, 174, DateTimeKind.Utc).AddTicks(7450),
                            Description = "",
                            IsDeleted = false,
                            LastModified = new DateTime(2023, 6, 27, 7, 36, 15, 174, DateTimeKind.Utc).AddTicks(7450),
                            Name = "Customer",
                            NormalizedName = "Customer"
                        },
                        new
                        {
                            Id = new Guid("bcf0f8de-c8c3-44ee-9c67-df972d604cf2"),
                            ConcurrencyStamp = "93a5b098-1310-46ed-b69c-a5e1dcb72860",
                            CreatedOn = new DateTime(2023, 6, 27, 7, 36, 15, 174, DateTimeKind.Utc).AddTicks(7460),
                            Description = "",
                            IsDeleted = false,
                            LastModified = new DateTime(2023, 6, 27, 7, 36, 15, 174, DateTimeKind.Utc).AddTicks(7460),
                            Name = "Staff",
                            NormalizedName = "Staff"
                        });
                });

            modelBuilder.Entity("Trivister.Core.Entities.ApplicationUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(500)");

                    b.Property<Guid?>("ApplicationRoleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(300)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(300)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDisabled")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(300)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("MiddleName")
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationRoleId");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("363b37a0-c306-4472-a405-4b576334cca0"),
                            AccessFailedCount = 0,
                            Address = "No 1 Jango street, wild wild west, Texas",
                            ConcurrencyStamp = "6c232942-ed53-4280-a7ca-17fa864eda69",
                            CreatedOn = new DateTime(2023, 6, 27, 7, 36, 15, 169, DateTimeKind.Utc).AddTicks(3300),
                            Email = "femi.ibitolu@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "Babafemi",
                            IsDeleted = false,
                            IsDisabled = false,
                            LastModified = new DateTime(2023, 6, 27, 7, 36, 15, 169, DateTimeKind.Utc).AddTicks(3300),
                            LastName = "Ibitolu",
                            LockoutEnabled = false,
                            NormalizedUserName = "FEMI.IBITOLU@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEFiyf2evei9JIUrUSbC6GyOfPZ4u7sZjg+KmNN9cXzN0idAxtdIiOEFezm4dXY+qcA==",
                            PhoneNumberConfirmed = false,
                            RoleId = 1,
                            TwoFactorEnabled = false,
                            UserName = "femi.ibitolu@gmail.com"
                        });
                });

            modelBuilder.Entity("Trivister.Core.Entities.OTPStore", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(400)");

                    b.Property<DateTime>("ExpiryDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsExpired")
                        .HasColumnType("bit");

                    b.Property<bool>("IsUsed")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OTP")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(400)");

                    b.HasKey("Id");

                    b.ToTable("OTPStore");
                });

            modelBuilder.Entity("Trivister.Core.Entities.Permission", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(400)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Permissions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedOn = new DateTime(2023, 6, 27, 7, 36, 15, 174, DateTimeKind.Utc).AddTicks(6800),
                            Description = "Can add user to the system",
                            IsDeleted = false,
                            LastModified = new DateTime(2023, 6, 27, 7, 36, 15, 174, DateTimeKind.Utc).AddTicks(6800),
                            Name = "CanAddUser"
                        },
                        new
                        {
                            Id = 2,
                            CreatedOn = new DateTime(2023, 6, 27, 7, 36, 15, 174, DateTimeKind.Utc).AddTicks(6800),
                            Description = "Can delete user",
                            IsDeleted = false,
                            LastModified = new DateTime(2023, 6, 27, 7, 36, 15, 174, DateTimeKind.Utc).AddTicks(6800),
                            Name = "CanDeleteUser"
                        },
                        new
                        {
                            Id = 3,
                            CreatedOn = new DateTime(2023, 6, 27, 7, 36, 15, 174, DateTimeKind.Utc).AddTicks(6800),
                            Description = "Can edit user",
                            IsDeleted = false,
                            LastModified = new DateTime(2023, 6, 27, 7, 36, 15, 174, DateTimeKind.Utc).AddTicks(6800),
                            Name = "CanEditUser"
                        },
                        new
                        {
                            Id = 4,
                            CreatedOn = new DateTime(2023, 6, 27, 7, 36, 15, 174, DateTimeKind.Utc).AddTicks(6800),
                            Description = "Can invite user",
                            IsDeleted = false,
                            LastModified = new DateTime(2023, 6, 27, 7, 36, 15, 174, DateTimeKind.Utc).AddTicks(6800),
                            Name = "CanInviteUser"
                        },
                        new
                        {
                            Id = 5,
                            CreatedOn = new DateTime(2023, 6, 27, 7, 36, 15, 174, DateTimeKind.Utc).AddTicks(6800),
                            Description = "Can View user",
                            IsDeleted = false,
                            LastModified = new DateTime(2023, 6, 27, 7, 36, 15, 174, DateTimeKind.Utc).AddTicks(6800),
                            Name = "CanViewUsers"
                        },
                        new
                        {
                            Id = 6,
                            CreatedOn = new DateTime(2023, 6, 27, 7, 36, 15, 174, DateTimeKind.Utc).AddTicks(6800),
                            Description = "Can View Loans",
                            IsDeleted = false,
                            LastModified = new DateTime(2023, 6, 27, 7, 36, 15, 174, DateTimeKind.Utc).AddTicks(6800),
                            Name = "CanViewLoans"
                        },
                        new
                        {
                            Id = 7,
                            CreatedOn = new DateTime(2023, 6, 27, 7, 36, 15, 174, DateTimeKind.Utc).AddTicks(6800),
                            Description = "Can Approve Loans",
                            IsDeleted = false,
                            LastModified = new DateTime(2023, 6, 27, 7, 36, 15, 174, DateTimeKind.Utc).AddTicks(6800),
                            Name = "CanApproveLoans"
                        },
                        new
                        {
                            Id = 8,
                            CreatedOn = new DateTime(2023, 6, 27, 7, 36, 15, 174, DateTimeKind.Utc).AddTicks(6810),
                            Description = "Can Reject Loans",
                            IsDeleted = false,
                            LastModified = new DateTime(2023, 6, 27, 7, 36, 15, 174, DateTimeKind.Utc).AddTicks(6810),
                            Name = "CanRejectLoans"
                        },
                        new
                        {
                            Id = 9,
                            CreatedOn = new DateTime(2023, 6, 27, 7, 36, 15, 174, DateTimeKind.Utc).AddTicks(6810),
                            Description = "Can WriteOff Loans",
                            IsDeleted = false,
                            LastModified = new DateTime(2023, 6, 27, 7, 36, 15, 174, DateTimeKind.Utc).AddTicks(6810),
                            Name = "CanWriteOffLoans"
                        },
                        new
                        {
                            Id = 10,
                            CreatedOn = new DateTime(2023, 6, 27, 7, 36, 15, 174, DateTimeKind.Utc).AddTicks(6810),
                            Description = "Can View Reports",
                            IsDeleted = false,
                            LastModified = new DateTime(2023, 6, 27, 7, 36, 15, 174, DateTimeKind.Utc).AddTicks(6810),
                            Name = "CanViewReports"
                        },
                        new
                        {
                            Id = 11,
                            CreatedOn = new DateTime(2023, 6, 27, 7, 36, 15, 174, DateTimeKind.Utc).AddTicks(6810),
                            Description = "Can Download Reports",
                            IsDeleted = false,
                            LastModified = new DateTime(2023, 6, 27, 7, 36, 15, 174, DateTimeKind.Utc).AddTicks(6810),
                            Name = "CanDownloadReports"
                        },
                        new
                        {
                            Id = 12,
                            CreatedOn = new DateTime(2023, 6, 27, 7, 36, 15, 174, DateTimeKind.Utc).AddTicks(6810),
                            Description = "Can Create Role",
                            IsDeleted = false,
                            LastModified = new DateTime(2023, 6, 27, 7, 36, 15, 174, DateTimeKind.Utc).AddTicks(6810),
                            Name = "CanCreateRole"
                        },
                        new
                        {
                            Id = 13,
                            CreatedOn = new DateTime(2023, 6, 27, 7, 36, 15, 174, DateTimeKind.Utc).AddTicks(6810),
                            Description = "Can Update Role",
                            IsDeleted = false,
                            LastModified = new DateTime(2023, 6, 27, 7, 36, 15, 174, DateTimeKind.Utc).AddTicks(6810),
                            Name = "CanUpdateRole"
                        },
                        new
                        {
                            Id = 14,
                            CreatedOn = new DateTime(2023, 6, 27, 7, 36, 15, 174, DateTimeKind.Utc).AddTicks(6810),
                            Description = "Can Add permissions to Role",
                            IsDeleted = false,
                            LastModified = new DateTime(2023, 6, 27, 7, 36, 15, 174, DateTimeKind.Utc).AddTicks(6810),
                            Name = "CanAddPermissionsToRole"
                        },
                        new
                        {
                            Id = 15,
                            CreatedOn = new DateTime(2023, 6, 27, 7, 36, 15, 174, DateTimeKind.Utc).AddTicks(6810),
                            Description = "Can View Roles",
                            IsDeleted = false,
                            LastModified = new DateTime(2023, 6, 27, 7, 36, 15, 174, DateTimeKind.Utc).AddTicks(6810),
                            Name = "CanViewRoles"
                        },
                        new
                        {
                            Id = 16,
                            CreatedOn = new DateTime(2023, 6, 27, 7, 36, 15, 174, DateTimeKind.Utc).AddTicks(6810),
                            Description = "Can View Tickets",
                            IsDeleted = false,
                            LastModified = new DateTime(2023, 6, 27, 7, 36, 15, 174, DateTimeKind.Utc).AddTicks(6810),
                            Name = "CanViewTickets"
                        },
                        new
                        {
                            Id = 17,
                            CreatedOn = new DateTime(2023, 6, 27, 7, 36, 15, 174, DateTimeKind.Utc).AddTicks(6820),
                            Description = "Can View Tickets",
                            IsDeleted = false,
                            LastModified = new DateTime(2023, 6, 27, 7, 36, 15, 174, DateTimeKind.Utc).AddTicks(6820),
                            Name = "CanViewTickets"
                        },
                        new
                        {
                            Id = 18,
                            CreatedOn = new DateTime(2023, 6, 27, 7, 36, 15, 174, DateTimeKind.Utc).AddTicks(6820),
                            Description = "Can Open/Close Tickets",
                            IsDeleted = false,
                            LastModified = new DateTime(2023, 6, 27, 7, 36, 15, 174, DateTimeKind.Utc).AddTicks(6820),
                            Name = "CanOpenOrCloseTicket"
                        },
                        new
                        {
                            Id = 19,
                            CreatedOn = new DateTime(2023, 6, 27, 7, 36, 15, 174, DateTimeKind.Utc).AddTicks(6820),
                            Description = "Can Respond to Tickets",
                            IsDeleted = false,
                            LastModified = new DateTime(2023, 6, 27, 7, 36, 15, 174, DateTimeKind.Utc).AddTicks(6820),
                            Name = "CanRespondToTicket"
                        },
                        new
                        {
                            Id = 20,
                            CreatedOn = new DateTime(2023, 6, 27, 7, 36, 15, 174, DateTimeKind.Utc).AddTicks(6820),
                            Description = "Can View Configurations",
                            IsDeleted = false,
                            LastModified = new DateTime(2023, 6, 27, 7, 36, 15, 174, DateTimeKind.Utc).AddTicks(6820),
                            Name = "CanViewConfigurations"
                        },
                        new
                        {
                            Id = 21,
                            CreatedOn = new DateTime(2023, 6, 27, 7, 36, 15, 174, DateTimeKind.Utc).AddTicks(6820),
                            Description = "Can Update Maker Checker Configurations",
                            IsDeleted = false,
                            LastModified = new DateTime(2023, 6, 27, 7, 36, 15, 174, DateTimeKind.Utc).AddTicks(6820),
                            Name = "CanUpdateMakerCheckerConfiguration"
                        },
                        new
                        {
                            Id = 22,
                            CreatedOn = new DateTime(2023, 6, 27, 7, 36, 15, 174, DateTimeKind.Utc).AddTicks(6820),
                            Description = "Can Create Loan Configuration",
                            IsDeleted = false,
                            LastModified = new DateTime(2023, 6, 27, 7, 36, 15, 174, DateTimeKind.Utc).AddTicks(6820),
                            Name = "CanCreateLoanConfiguration"
                        },
                        new
                        {
                            Id = 23,
                            CreatedOn = new DateTime(2023, 6, 27, 7, 36, 15, 174, DateTimeKind.Utc).AddTicks(6820),
                            Description = "Can Update Loan Configuration",
                            IsDeleted = false,
                            LastModified = new DateTime(2023, 6, 27, 7, 36, 15, 174, DateTimeKind.Utc).AddTicks(6820),
                            Name = "CanUpdateLoanConfiguration"
                        },
                        new
                        {
                            Id = 24,
                            CreatedOn = new DateTime(2023, 6, 27, 7, 36, 15, 174, DateTimeKind.Utc).AddTicks(6820),
                            Description = "Can Delete Loan Configuration",
                            IsDeleted = false,
                            LastModified = new DateTime(2023, 6, 27, 7, 36, 15, 174, DateTimeKind.Utc).AddTicks(6820),
                            Name = "CanDeleteLoanConfiguration"
                        });
                });

            modelBuilder.Entity("Trivister.Core.Entities.RolesPermission", b =>
                {
                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("PermissionId")
                        .HasColumnType("int");

                    b.HasKey("RoleId", "PermissionId");

                    b.HasIndex("PermissionId");

                    b.ToTable("RolesPermissions");

                    b.HasData(
                        new
                        {
                            RoleId = new Guid("3e7d9440-48d7-4174-b9c5-0ea5be7d9e7d"),
                            PermissionId = 1
                        },
                        new
                        {
                            RoleId = new Guid("3e7d9440-48d7-4174-b9c5-0ea5be7d9e7d"),
                            PermissionId = 2
                        },
                        new
                        {
                            RoleId = new Guid("3e7d9440-48d7-4174-b9c5-0ea5be7d9e7d"),
                            PermissionId = 3
                        });
                });

            modelBuilder.Entity("Trivister.Core.Entities.UsersRole", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LastModified")
                        .HasColumnType("datetime2");

                    b.HasDiscriminator().HasValue("UsersRole");

                    b.HasData(
                        new
                        {
                            UserId = new Guid("363b37a0-c306-4472-a405-4b576334cca0"),
                            RoleId = new Guid("3e7d9440-48d7-4174-b9c5-0ea5be7d9e7d"),
                            IsDeleted = false,
                            LastModified = new DateTime(2023, 6, 27, 7, 36, 15, 175, DateTimeKind.Utc).AddTicks(70)
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.HasOne("Trivister.Core.Entities.ApplicationRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.HasOne("Trivister.Core.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.HasOne("Trivister.Core.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.HasOne("Trivister.Core.Entities.ApplicationRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Trivister.Core.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.HasOne("Trivister.Core.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Trivister.Core.Entities.ApplicationUser", b =>
                {
                    b.HasOne("Trivister.Core.Entities.ApplicationRole", null)
                        .WithMany("ApplicationUsers")
                        .HasForeignKey("ApplicationRoleId");
                });

            modelBuilder.Entity("Trivister.Core.Entities.RolesPermission", b =>
                {
                    b.HasOne("Trivister.Core.Entities.Permission", "Permission")
                        .WithMany()
                        .HasForeignKey("PermissionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Trivister.Core.Entities.ApplicationRole", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Permission");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("Trivister.Core.Entities.ApplicationRole", b =>
                {
                    b.Navigation("ApplicationUsers");
                });
#pragma warning restore 612, 618
        }
    }
}
