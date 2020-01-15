﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StockManager.Database;

namespace StockManager.Database.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0");

            modelBuilder.Entity("StockManager.Database.Models.Location", b =>
                {
                    b.Property<int>("LocationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.HasKey("LocationId");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("StockManager.Database.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Reference")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.HasKey("ProductId");

                    b.HasIndex("Reference")
                        .IsUnique()
                        .HasName("UniqueReference");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("StockManager.Database.Models.ProductLocation", b =>
                {
                    b.Property<int>("ProductLocationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<int>("LocationId")
                        .HasColumnType("INTEGER");

                    b.Property<float>("MinStock")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("REAL")
                        .HasDefaultValue(0f);

                    b.Property<int>("ProductId")
                        .HasColumnType("INTEGER");

                    b.Property<float>("Stock")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("REAL")
                        .HasDefaultValue(0f);

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.HasKey("ProductLocationId");

                    b.HasIndex("LocationId");

                    b.HasIndex("ProductId", "LocationId")
                        .IsUnique()
                        .HasName("UniqueProductIdLocationIdPair");

                    b.ToTable("ProductLocations");
                });

            modelBuilder.Entity("StockManager.Database.Models.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.HasKey("RoleId");

                    b.HasIndex("Code")
                        .IsUnique()
                        .HasName("UniqueCode");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            RoleId = 1,
                            Code = "Admin",
                            CreatedAt = new DateTime(2020, 1, 15, 21, 14, 59, 907, DateTimeKind.Utc).AddTicks(4789),
                            UpdatedAt = new DateTime(2020, 1, 15, 21, 14, 59, 907, DateTimeKind.Utc).AddTicks(4789)
                        },
                        new
                        {
                            RoleId = 2,
                            Code = "User",
                            CreatedAt = new DateTime(2020, 1, 15, 21, 14, 59, 907, DateTimeKind.Utc).AddTicks(4789),
                            UpdatedAt = new DateTime(2020, 1, 15, 21, 14, 59, 907, DateTimeKind.Utc).AddTicks(4789)
                        });
                });

            modelBuilder.Entity("StockManager.Database.Models.StockMovement", b =>
                {
                    b.Property<int>("StockMovementId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<int>("FromLocationId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("LocationId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProductId")
                        .HasColumnType("INTEGER");

                    b.Property<float>("Qty")
                        .HasColumnType("REAL");

                    b.Property<float>("Stock")
                        .HasColumnType("REAL");

                    b.Property<int>("ToLocationId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("StockMovementId");

                    b.HasIndex("LocationId");

                    b.HasIndex("ProductId");

                    b.HasIndex("UserId");

                    b.ToTable("StockMovements");
                });

            modelBuilder.Entity("StockManager.Database.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("LastLogin")
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("RoleId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("UserId");

                    b.HasIndex("RoleId");

                    b.HasIndex("Username")
                        .IsUnique()
                        .HasName("UniqueUsername");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            CreatedAt = new DateTime(2020, 1, 15, 21, 15, 0, 5, DateTimeKind.Utc).AddTicks(4235),
                            Password = "$2b$10$vL3qzkYxXl6C4Iq4Rqeby.0eoBK8TGZn2KXVyHp3Lo4iJQQre9Cuu",
                            RoleId = 1,
                            UpdatedAt = new DateTime(2020, 1, 15, 21, 15, 0, 5, DateTimeKind.Utc).AddTicks(4235),
                            Username = "Admin"
                        });
                });

            modelBuilder.Entity("StockManager.Database.Models.ProductLocation", b =>
                {
                    b.HasOne("StockManager.Database.Models.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StockManager.Database.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("StockManager.Database.Models.StockMovement", b =>
                {
                    b.HasOne("StockManager.Database.Models.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId");

                    b.HasOne("StockManager.Database.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StockManager.Database.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("StockManager.Database.Models.User", b =>
                {
                    b.HasOne("StockManager.Database.Models.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
