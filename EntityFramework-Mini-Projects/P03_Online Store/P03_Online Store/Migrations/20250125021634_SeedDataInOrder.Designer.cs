﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using P03_Online_Store.Data;

#nullable disable

namespace P03_Online_Store.Migrations
{
    [DbContext(typeof(OnlineStoreContext))]
    [Migration("20250125021634_SeedDataInOrder")]
    partial class SeedDataInOrder
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("P03_Online_Store.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerId"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(200)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("CustomerId");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            CustomerId = 1,
                            Address = "Cairo",
                            Email = "example@email.com",
                            Name = "Abdelwahab Shandy",
                            Password = "*******",
                            Phone = "87878798",
                            UserName = "as_Cyber"
                        },
                        new
                        {
                            CustomerId = 2,
                            Address = "Cairo",
                            Email = "as@mail.org",
                            Name = "Anas Shandy",
                            Password = "*******",
                            Phone = "87878798",
                            UserName = "as_ber"
                        });
                });

            modelBuilder.Entity("P03_Online_Store.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderId"));

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<double>("TotalAmount")
                        .HasColumnType("float");

                    b.HasKey("OrderId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            OrderId = 1,
                            CustomerId = 1,
                            OrderDate = new DateTime(2025, 1, 25, 4, 16, 34, 114, DateTimeKind.Local).AddTicks(7050),
                            Status = 0,
                            TotalAmount = 600.5
                        },
                        new
                        {
                            OrderId = 2,
                            CustomerId = 2,
                            OrderDate = new DateTime(2025, 1, 25, 4, 16, 34, 114, DateTimeKind.Local).AddTicks(7092),
                            Status = 1,
                            TotalAmount = 300.5
                        });
                });

            modelBuilder.Entity("P03_Online_Store.Models.OrderItem", b =>
                {
                    b.Property<int>("OrderItemId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<double>("TotalItemsPrice")
                        .HasColumnType("float");

                    b.HasKey("OrderItemId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("P03_Online_Store.Models.Payment", b =>
                {
                    b.Property<int>("PaymentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PaymentId"));

                    b.Property<double>("Amount")
                        .HasColumnType("float");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<string>("PaymentMethod")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("TransactionDate")
                        .HasColumnType("datetime2");

                    b.HasKey("PaymentId");

                    b.HasIndex("OrderId");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("P03_Online_Store.Models.ProductCatalog", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(500)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("QuantityInStock")
                        .HasColumnType("int");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.ToTable("ProductCatalogs");
                });

            modelBuilder.Entity("P03_Online_Store.Models.ProductCategory", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("CategoryId");

                    b.ToTable("ProductCategories");
                });

            modelBuilder.Entity("P03_Online_Store.Models.ProductImage", b =>
                {
                    b.Property<int>("ImageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ImageId"));

                    b.Property<int>("ImageOrder")
                        .HasColumnType("int");

                    b.Property<string>("ImageURL")
                        .IsRequired()
                        .HasMaxLength(400)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(400)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("ImageId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductImages");
                });

            modelBuilder.Entity("P03_Online_Store.Models.Review", b =>
                {
                    b.Property<int>("ReviewId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReviewId"));

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<double>("Rating")
                        .HasColumnType("float");

                    b.Property<DateTime>("ReviewDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ReviewText")
                        .IsRequired()
                        .HasMaxLength(500)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("ReviewId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("ProductId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("P03_Online_Store.Models.Shipping", b =>
                {
                    b.Property<int>("ShippingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ShippingId"));

                    b.Property<DateTime>("ActualDeliveryDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CarrierName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("EstimatedDeliveryDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("ShippingStatus")
                        .HasColumnType("int");

                    b.Property<string>("TrackingNumber")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ShippingId");

                    b.HasIndex("OrderId");

                    b.ToTable("Shippings");
                });

            modelBuilder.Entity("P03_Online_Store.Models.Order", b =>
                {
                    b.HasOne("P03_Online_Store.Models.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("P03_Online_Store.Models.OrderItem", b =>
                {
                    b.HasOne("P03_Online_Store.Models.Order", "Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("P03_Online_Store.Models.ProductCatalog", "ProductCatalog")
                        .WithMany("OrderItems")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("ProductCatalog");
                });

            modelBuilder.Entity("P03_Online_Store.Models.Payment", b =>
                {
                    b.HasOne("P03_Online_Store.Models.Order", "Order")
                        .WithMany("Payments")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");
                });

            modelBuilder.Entity("P03_Online_Store.Models.ProductCatalog", b =>
                {
                    b.HasOne("P03_Online_Store.Models.ProductCategory", "ProductCategory")
                        .WithMany("ProductCatalogs")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProductCategory");
                });

            modelBuilder.Entity("P03_Online_Store.Models.ProductImage", b =>
                {
                    b.HasOne("P03_Online_Store.Models.ProductCatalog", "ProductCatalog")
                        .WithMany("ProductImages")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProductCatalog");
                });

            modelBuilder.Entity("P03_Online_Store.Models.Review", b =>
                {
                    b.HasOne("P03_Online_Store.Models.Customer", "Customer")
                        .WithMany("Reviews")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("P03_Online_Store.Models.ProductCatalog", "ProductCatalog")
                        .WithMany("Reviews")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("ProductCatalog");
                });

            modelBuilder.Entity("P03_Online_Store.Models.Shipping", b =>
                {
                    b.HasOne("P03_Online_Store.Models.Order", "Order")
                        .WithMany("Shippings")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");
                });

            modelBuilder.Entity("P03_Online_Store.Models.Customer", b =>
                {
                    b.Navigation("Orders");

                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("P03_Online_Store.Models.Order", b =>
                {
                    b.Navigation("OrderItems");

                    b.Navigation("Payments");

                    b.Navigation("Shippings");
                });

            modelBuilder.Entity("P03_Online_Store.Models.ProductCatalog", b =>
                {
                    b.Navigation("OrderItems");

                    b.Navigation("ProductImages");

                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("P03_Online_Store.Models.ProductCategory", b =>
                {
                    b.Navigation("ProductCatalogs");
                });
#pragma warning restore 612, 618
        }
    }
}
