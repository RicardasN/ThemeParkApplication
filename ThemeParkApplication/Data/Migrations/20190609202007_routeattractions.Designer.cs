﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ThemeParkApplication.Data;

namespace ThemeParkApplication.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20190609202007_routeattractions")]
    partial class routeattractions
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

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

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasMaxLength(128);

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("ThemeParkApplication.Models.ApplicationRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<DateTime>("CreationDate");

                    b.Property<string>("Description");

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("ThemeParkApplication.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("Nickname");

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
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("ThemeParkApplication.Models.Attraction", b =>
                {
                    b.Property<int>("AttractionID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("ImageSrc")
                        .IsRequired();

                    b.Property<bool>("IsOpen");

                    b.Property<string>("Location")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<float>("Rating");

                    b.Property<int?>("WorkingHours");

                    b.HasKey("AttractionID");

                    b.HasIndex("WorkingHours");

                    b.ToTable("Attractions");

                    b.HasData(
                        new { AttractionID = 1, Description = "This attraction offers amazing experience for a good price!", ImageSrc = "https://cdn.pixabay.com/photo/2014/09/17/03/19/roller-coaster-449137_960_720.jpg", IsOpen = false, Location = "SW", Name = "Kraken", Rating = 3.4f },
                        new { AttractionID = 2, Description = "This attraction has a well balanced mix of scary twists and speed, are you ready for that?", ImageSrc = "https://upload.wikimedia.org/wikipedia/commons/3/39/Adlabs_Imagica_2013_%2810364145606%29.jpg", IsOpen = false, Location = "NW", Name = "DeathRide", Rating = 4.4f },
                        new { AttractionID = 3, Description = "This attraction offers amazing experience for a good price!", ImageSrc = "https://upload.wikimedia.org/wikipedia/commons/d/d4/Dorney_Park_Steel_Force_Thunderhawk.jpg", IsOpen = false, Location = "SE", Name = "Loop", Rating = 4.9f }
                    );
                });

            modelBuilder.Entity("ThemeParkApplication.Models.Cafeteria", b =>
                {
                    b.Property<int>("CafeteriaID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AvailableSpaces");

                    b.Property<string>("Expensiveness");

                    b.Property<string>("Location")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int?>("RouteID");

                    b.HasKey("CafeteriaID");

                    b.HasIndex("RouteID");

                    b.ToTable("Cafeteria");
                });

            modelBuilder.Entity("ThemeParkApplication.Models.Message", b =>
                {
                    b.Property<int>("MessageID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("SentTime");

                    b.Property<string>("Text")
                        .IsRequired();

                    b.Property<string>("Username");

                    b.HasKey("MessageID");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("ThemeParkApplication.Models.Route", b =>
                {
                    b.Property<int>("RouteID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ApplicationUser");

                    b.Property<int>("TempAtractionID");

                    b.HasKey("RouteID");

                    b.ToTable("Routes");
                });

            modelBuilder.Entity("ThemeParkApplication.Models.RouteAttraction", b =>
                {
                    b.Property<int>("AtractionId");

                    b.Property<int>("RouteId");

                    b.Property<int?>("AttractionID");

                    b.HasKey("AtractionId", "RouteId");

                    b.HasIndex("AttractionID");

                    b.HasIndex("RouteId");

                    b.ToTable("RouteAttractions");
                });

            modelBuilder.Entity("ThemeParkApplication.Models.Ticket", b =>
                {
                    b.Property<int>("TicketID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Bank");

                    b.Property<DateTime>("PaymentDate");

                    b.Property<bool>("PaymentState");

                    b.Property<int>("Type");

                    b.Property<string>("Username");

                    b.HasKey("TicketID");

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("ThemeParkApplication.Models.WorkingHours", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("ClosingHours");

                    b.Property<string>("DayOfWeek");

                    b.Property<DateTime>("StartingHours");

                    b.HasKey("Id");

                    b.ToTable("WorkingHours");

                    b.HasData(
                        new { Id = 2, ClosingHours = new DateTime(2019, 7, 15, 23, 20, 7, 132, DateTimeKind.Local), DayOfWeek = "Sunday", StartingHours = new DateTime(2019, 7, 15, 23, 20, 7, 132, DateTimeKind.Local) },
                        new { Id = 3, ClosingHours = new DateTime(2019, 7, 15, 23, 20, 7, 132, DateTimeKind.Local), DayOfWeek = "Sunday", StartingHours = new DateTime(2019, 7, 15, 23, 20, 7, 132, DateTimeKind.Local) }
                    );
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("ThemeParkApplication.Models.ApplicationRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("ThemeParkApplication.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("ThemeParkApplication.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("ThemeParkApplication.Models.ApplicationRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ThemeParkApplication.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("ThemeParkApplication.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ThemeParkApplication.Models.Attraction", b =>
                {
                    b.HasOne("ThemeParkApplication.Models.WorkingHours", "VisitingHours")
                        .WithMany()
                        .HasForeignKey("WorkingHours");
                });

            modelBuilder.Entity("ThemeParkApplication.Models.Cafeteria", b =>
                {
                    b.HasOne("ThemeParkApplication.Models.Route")
                        .WithMany("RouteCafeterias")
                        .HasForeignKey("RouteID");
                });

            modelBuilder.Entity("ThemeParkApplication.Models.RouteAttraction", b =>
                {
                    b.HasOne("ThemeParkApplication.Models.Attraction", "Attraction")
                        .WithMany()
                        .HasForeignKey("AttractionID");

                    b.HasOne("ThemeParkApplication.Models.Route", "Route")
                        .WithMany("RouteAttractions")
                        .HasForeignKey("RouteId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
