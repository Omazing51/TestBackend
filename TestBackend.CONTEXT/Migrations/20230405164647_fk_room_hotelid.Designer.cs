﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TestBackend.CONTEXT.Context;

#nullable disable

namespace TestBackend.CONTEXT.Migrations
{
    [DbContext(typeof(TestBackendContext))]
    [Migration("20230405164647_fk_room_hotelid")]
    partial class fk_room_hotelid
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("TestBackend.MODEL.Entities.Booking", b =>
                {
                    b.Property<int>("bookingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("bookingId"));

                    b.Property<int>("bookingStatuslId")
                        .HasColumnType("int");

                    b.Property<int>("hotelId")
                        .HasColumnType("int");

                    b.HasKey("bookingId");

                    b.HasIndex("bookingStatuslId");

                    b.HasIndex("hotelId");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("TestBackend.MODEL.Entities.BookingDetail", b =>
                {
                    b.Property<int>("bookingDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("bookingDetailId"));

                    b.Property<DateTime>("birthDayUser")
                        .HasColumnType("datetime2");

                    b.Property<int>("bookingId")
                        .HasColumnType("int");

                    b.Property<string>("contactName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("emailUser")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("endBooking")
                        .HasColumnType("datetime2");

                    b.Property<string>("firstLastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("firstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("identificationType")
                        .HasColumnType("int");

                    b.Property<int>("identificationUser")
                        .HasColumnType("int");

                    b.Property<string>("phoneNumberContact")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phoneNumberUser")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("secondLastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("secondName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("startBooking")
                        .HasColumnType("datetime2");

                    b.HasKey("bookingDetailId");

                    b.HasIndex("bookingId");

                    b.ToTable("BookingDetails");
                });

            modelBuilder.Entity("TestBackend.MODEL.Entities.BookingStatus", b =>
                {
                    b.Property<int>("statusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("statusId"));

                    b.Property<string>("statusDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("statusId");

                    b.ToTable("BookingStatuses");
                });

            modelBuilder.Entity("TestBackend.MODEL.Entities.City", b =>
                {
                    b.Property<int>("cityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("cityId"));

                    b.Property<string>("cityName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("countryId")
                        .HasColumnType("int");

                    b.HasKey("cityId");

                    b.HasIndex("countryId");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("TestBackend.MODEL.Entities.Country", b =>
                {
                    b.Property<int>("countryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("countryId"));

                    b.Property<string>("countryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("countryId");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("TestBackend.MODEL.Entities.Hotel", b =>
                {
                    b.Property<int>("hotelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("hotelId"));

                    b.Property<int>("hotelClassId")
                        .HasColumnType("int");

                    b.Property<string>("hotelDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("hotelName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("hotelStatusId")
                        .HasColumnType("int");

                    b.Property<int>("locationId")
                        .HasColumnType("int");

                    b.HasKey("hotelId");

                    b.HasIndex("hotelClassId");

                    b.HasIndex("hotelStatusId");

                    b.HasIndex("locationId");

                    b.ToTable("Hotels");
                });

            modelBuilder.Entity("TestBackend.MODEL.Entities.HotelClass", b =>
                {
                    b.Property<int>("hotelClassId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("hotelClassId"));

                    b.Property<string>("hotelClassDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("hotelClassName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("hotelClassId");

                    b.ToTable("HotelClasses");
                });

            modelBuilder.Entity("TestBackend.MODEL.Entities.HotelImage", b =>
                {
                    b.Property<int>("imageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("imageId"));

                    b.Property<int>("hotelId")
                        .HasColumnType("int");

                    b.Property<string>("imageDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("imageTittle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("imageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("imageId");

                    b.HasIndex("hotelId");

                    b.ToTable("HotelImages");
                });

            modelBuilder.Entity("TestBackend.MODEL.Entities.HotelStatus", b =>
                {
                    b.Property<int>("statusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("statusId"));

                    b.Property<string>("statusDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("statusId");

                    b.ToTable("HotelStatuses");
                });

            modelBuilder.Entity("TestBackend.MODEL.Entities.Location", b =>
                {
                    b.Property<int>("locationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("locationId"));

                    b.Property<int>("cityId")
                        .HasColumnType("int");

                    b.Property<string>("locationDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("postalCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("locationId");

                    b.HasIndex("cityId");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("TestBackend.MODEL.Entities.Room", b =>
                {
                    b.Property<int>("roomId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("roomId"));

                    b.Property<int>("hotelId")
                        .HasColumnType("int");

                    b.Property<string>("location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("roomDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("roomName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("roomId");

                    b.HasIndex("hotelId");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("TestBackend.MODEL.Entities.RoomImage", b =>
                {
                    b.Property<int>("imageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("imageId"));

                    b.Property<string>("imageDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("imageTittle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("imageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("imageId");

                    b.ToTable("RoomImages");
                });

            modelBuilder.Entity("TestBackend.MODEL.Entities.RoomStatus", b =>
                {
                    b.Property<int>("statusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("statusId"));

                    b.Property<string>("statusDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("statusId");

                    b.ToTable("RoomStatuses");
                });

            modelBuilder.Entity("TestBackend.MODEL.Entities.RoomType", b =>
                {
                    b.Property<int>("typeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("typeId"));

                    b.Property<string>("DescriptionType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("totalJacuzzi")
                        .HasColumnType("int");

                    b.Property<int>("totalPerson")
                        .HasColumnType("int");

                    b.Property<int?>("totalToilet")
                        .HasColumnType("int");

                    b.Property<int?>("totalTv")
                        .HasColumnType("int");

                    b.Property<decimal>("totalValue")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("typeId");

                    b.ToTable("RoomTypes");
                });

            modelBuilder.Entity("TestBackend.MODEL.Entities.Service", b =>
                {
                    b.Property<int>("serviceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("serviceId"));

                    b.Property<string>("serviceDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("serviceName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("serviceId");

                    b.ToTable("Services");
                });

            modelBuilder.Entity("TestBackend.MODEL.Entities.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("userPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("TestBackend.MODEL.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("TestBackend.MODEL.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TestBackend.MODEL.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("TestBackend.MODEL.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TestBackend.MODEL.Entities.Booking", b =>
                {
                    b.HasOne("TestBackend.MODEL.Entities.BookingStatus", "BookingStatus")
                        .WithMany()
                        .HasForeignKey("bookingStatuslId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TestBackend.MODEL.Entities.Hotel", "Hotel")
                        .WithMany()
                        .HasForeignKey("hotelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BookingStatus");

                    b.Navigation("Hotel");
                });

            modelBuilder.Entity("TestBackend.MODEL.Entities.BookingDetail", b =>
                {
                    b.HasOne("TestBackend.MODEL.Entities.Booking", "Booking")
                        .WithMany()
                        .HasForeignKey("bookingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Booking");
                });

            modelBuilder.Entity("TestBackend.MODEL.Entities.City", b =>
                {
                    b.HasOne("TestBackend.MODEL.Entities.Country", "Country")
                        .WithMany()
                        .HasForeignKey("countryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("TestBackend.MODEL.Entities.Hotel", b =>
                {
                    b.HasOne("TestBackend.MODEL.Entities.HotelClass", "HotelClass")
                        .WithMany()
                        .HasForeignKey("hotelClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TestBackend.MODEL.Entities.HotelStatus", "HotelStatus")
                        .WithMany()
                        .HasForeignKey("hotelStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TestBackend.MODEL.Entities.Location", "Location")
                        .WithMany()
                        .HasForeignKey("locationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HotelClass");

                    b.Navigation("HotelStatus");

                    b.Navigation("Location");
                });

            modelBuilder.Entity("TestBackend.MODEL.Entities.HotelImage", b =>
                {
                    b.HasOne("TestBackend.MODEL.Entities.Hotel", "Hotel")
                        .WithMany()
                        .HasForeignKey("hotelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hotel");
                });

            modelBuilder.Entity("TestBackend.MODEL.Entities.Location", b =>
                {
                    b.HasOne("TestBackend.MODEL.Entities.City", "City")
                        .WithMany()
                        .HasForeignKey("cityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("TestBackend.MODEL.Entities.Room", b =>
                {
                    b.HasOne("TestBackend.MODEL.Entities.Hotel", "Hotel")
                        .WithMany()
                        .HasForeignKey("hotelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hotel");
                });
#pragma warning restore 612, 618
        }
    }
}
