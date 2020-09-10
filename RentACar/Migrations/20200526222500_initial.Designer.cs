﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RentACar.Context;

namespace RentACar.Migrations
{
    [DbContext(typeof(MasterContext))]
    [Migration("20200526222500_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113");

            modelBuilder.Entity("RentACar.Models.CarModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Carbrand");

                    b.Property<string>("Carmodel");

                    b.Property<int>("Gearbox");

                    b.Property<int>("Price");

                    b.HasKey("Id");

                    b.ToTable("CarModels");
                });

            modelBuilder.Entity("RentACar.Models.RentaCarModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CarId");

                    b.Property<DateTime>("DeliveryDate");

                    b.Property<DateTime>("PickupDate");

                    b.Property<int>("TotalPrice");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("CarId")
                        .IsUnique();

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("RentaCarModels");
                });

            modelBuilder.Entity("RentACar.Models.UserModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(11);

                    b.Property<string>("Surname")
                        .IsRequired();

                    b.Property<string>("UserName")
                        .IsRequired();

                    b.Property<short>("isSuperAdmin");

                    b.HasKey("Id");

                    b.ToTable("UserModels");
                });

            modelBuilder.Entity("RentACar.Models.RentaCarModel", b =>
                {
                    b.HasOne("RentACar.Models.CarModel", "CarModel")
                        .WithOne("RentaCarModel")
                        .HasForeignKey("RentACar.Models.RentaCarModel", "CarId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("RentACar.Models.UserModel", "UserModel")
                        .WithOne("RentaCarModel")
                        .HasForeignKey("RentACar.Models.RentaCarModel", "UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
