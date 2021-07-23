﻿// <auto-generated />
using System;
using LoadManagerPrototype.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LoadManagerPrototype.Migrations
{
    [DbContext(typeof(LoadManagerPrototypeContext))]
    partial class LoadManagerPrototypeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LoadManagerPrototype.Models.Carrier", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("McNumber")
                        .HasColumnType("nvarchar(8)")
                        .HasMaxLength(8);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(2)")
                        .HasMaxLength(2);

                    b.Property<string>("Zip")
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.HasKey("Id");

                    b.HasIndex("McNumber")
                        .IsUnique()
                        .HasFilter("[McNumber] IS NOT NULL");

                    b.ToTable("Carrier");
                });

            modelBuilder.Entity("LoadManagerPrototype.Models.Commodity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("Commodity");
                });

            modelBuilder.Entity("LoadManagerPrototype.Models.CommodityDelivery", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CommodityId")
                        .HasColumnType("int");

                    b.Property<int>("DeliveryId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("Unit")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("CommodityId");

                    b.HasIndex("DeliveryId");

                    b.ToTable("CommodityDelivery");
                });

            modelBuilder.Entity("LoadManagerPrototype.Models.CommodityPickup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CommodityId")
                        .HasColumnType("int");

                    b.Property<int>("PickupId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("Unit")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("CommodityId");

                    b.HasIndex("PickupId");

                    b.ToTable("CommodityPickup");
                });

            modelBuilder.Entity("LoadManagerPrototype.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(12)")
                        .HasMaxLength(12);

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(2)")
                        .HasMaxLength(2);

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("Zip")
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("LoadManagerPrototype.Models.Delivery", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DropDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("LoadId")
                        .HasColumnType("int");

                    b.Property<bool>("OnSite")
                        .HasColumnType("bit");

                    b.Property<int>("ShedId")
                        .HasColumnType("int");

                    b.Property<bool>("Unloaded")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("LoadId");

                    b.HasIndex("ShedId");

                    b.ToTable("Delivery");
                });

            modelBuilder.Entity("LoadManagerPrototype.Models.Dispatcher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CarrierId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Fax")
                        .HasColumnType("nvarchar(12)")
                        .HasMaxLength(12);

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<bool>("IsCckApproved")
                        .HasColumnType("bit");

                    b.Property<string>("Lastname")
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(12)")
                        .HasMaxLength(12);

                    b.HasKey("Id");

                    b.HasIndex("CarrierId");

                    b.ToTable("Dispatcher");
                });

            modelBuilder.Entity("LoadManagerPrototype.Models.Driver", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CarrierId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("Equipment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Firstname")
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<bool>("IsCckApproved")
                        .HasColumnType("bit");

                    b.Property<string>("Lastname")
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(12)")
                        .HasMaxLength(12);

                    b.Property<string>("TrailerNumber")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("TruckNumber")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.HasIndex("CarrierId");

                    b.ToTable("Driver");
                });

            modelBuilder.Entity("LoadManagerPrototype.Models.Load", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CarrierId")
                        .HasColumnType("int");

                    b.Property<decimal>("CustomerBillRate")
                        .HasColumnType("decimal(9,2)");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<decimal>("PayTruckRate")
                        .HasColumnType("decimal(9,2)");

                    b.Property<int>("PoNumber")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CarrierId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("UserId");

                    b.ToTable("Load");
                });

            modelBuilder.Entity("LoadManagerPrototype.Models.Pickup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("LoadId")
                        .HasColumnType("int");

                    b.Property<bool>("Loaded")
                        .HasColumnType("bit");

                    b.Property<bool>("OnSite")
                        .HasColumnType("bit");

                    b.Property<DateTime>("PickDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ShedId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LoadId");

                    b.HasIndex("ShedId");

                    b.ToTable("Pickup");
                });

            modelBuilder.Entity("LoadManagerPrototype.Models.Shed", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Instructions")
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(12)")
                        .HasMaxLength(12);

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(2)")
                        .HasMaxLength(2);

                    b.Property<string>("Zip")
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.HasKey("Id");

                    b.ToTable("Shed");
                });

            modelBuilder.Entity("LoadManagerPrototype.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Firstname")
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("bit");

                    b.Property<string>("Lastname")
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(12)")
                        .HasMaxLength(12);

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.HasKey("Id");

                    b.HasIndex("Username")
                        .IsUnique();

                    b.ToTable("User");
                });

            modelBuilder.Entity("LoadManagerPrototype.Models.CommodityDelivery", b =>
                {
                    b.HasOne("LoadManagerPrototype.Models.Commodity", "commodity")
                        .WithMany()
                        .HasForeignKey("CommodityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LoadManagerPrototype.Models.Delivery", "delivery")
                        .WithMany("CommodityDeliveries")
                        .HasForeignKey("DeliveryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("LoadManagerPrototype.Models.CommodityPickup", b =>
                {
                    b.HasOne("LoadManagerPrototype.Models.Commodity", "commodity")
                        .WithMany()
                        .HasForeignKey("CommodityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LoadManagerPrototype.Models.Pickup", "pickup")
                        .WithMany("CommodityPickups")
                        .HasForeignKey("PickupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("LoadManagerPrototype.Models.Customer", b =>
                {
                    b.HasOne("LoadManagerPrototype.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("LoadManagerPrototype.Models.Delivery", b =>
                {
                    b.HasOne("LoadManagerPrototype.Models.Load", null)
                        .WithMany("Deliveries")
                        .HasForeignKey("LoadId");

                    b.HasOne("LoadManagerPrototype.Models.Shed", "shed")
                        .WithMany()
                        .HasForeignKey("ShedId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("LoadManagerPrototype.Models.Dispatcher", b =>
                {
                    b.HasOne("LoadManagerPrototype.Models.Carrier", "Carrier")
                        .WithMany("Dispatchers")
                        .HasForeignKey("CarrierId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("LoadManagerPrototype.Models.Driver", b =>
                {
                    b.HasOne("LoadManagerPrototype.Models.Carrier", "Carrier")
                        .WithMany("Drivers")
                        .HasForeignKey("CarrierId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("LoadManagerPrototype.Models.Load", b =>
                {
                    b.HasOne("LoadManagerPrototype.Models.Carrier", "Carrier")
                        .WithMany()
                        .HasForeignKey("CarrierId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LoadManagerPrototype.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LoadManagerPrototype.Models.User", null)
                        .WithMany("Loads")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("LoadManagerPrototype.Models.Pickup", b =>
                {
                    b.HasOne("LoadManagerPrototype.Models.Load", null)
                        .WithMany("Pickups")
                        .HasForeignKey("LoadId");

                    b.HasOne("LoadManagerPrototype.Models.Shed", "shed")
                        .WithMany()
                        .HasForeignKey("ShedId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
