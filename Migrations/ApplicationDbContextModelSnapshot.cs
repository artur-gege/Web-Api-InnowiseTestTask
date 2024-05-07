﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WEB_API_Innowise_TestTask.Data;

#nullable disable

namespace WEB_API_Innowise_TestTask.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WEB_API_Innowise_TestTask.Models.Fridge", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("FridgeModelId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OwnerName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Fridges", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FridgeModelId = 1,
                            Name = "Kitchen Fridge",
                            OwnerName = "John Doe"
                        },
                        new
                        {
                            Id = 2,
                            FridgeModelId = 2,
                            Name = "Cellar Fridge",
                            OwnerName = "Jane Smith"
                        },
                        new
                        {
                            Id = 3,
                            FridgeModelId = 3,
                            Name = "Garage Fridge",
                            OwnerName = "Bob Johnson"
                        });
                });

            modelBuilder.Entity("WEB_API_Innowise_TestTask.Models.FridgeModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("FridgeModels", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Samsung RF28R7551SR",
                            Year = 2020
                        },
                        new
                        {
                            Id = 2,
                            Name = "LG LFXS28968S",
                            Year = 2021
                        },
                        new
                        {
                            Id = 3,
                            Name = "ATLANT GNE29GMHES",
                            Year = 2022
                        });
                });

            modelBuilder.Entity("WEB_API_Innowise_TestTask.Models.FridgeProducts", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("FridgeId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("FridgesProducts", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FridgeId = 1,
                            ProductId = 1,
                            Quantity = 5
                        },
                        new
                        {
                            Id = 2,
                            FridgeId = 1,
                            ProductId = 2,
                            Quantity = 3
                        },
                        new
                        {
                            Id = 3,
                            FridgeId = 1,
                            ProductId = 3,
                            Quantity = 10
                        },
                        new
                        {
                            Id = 4,
                            FridgeId = 1,
                            ProductId = 4,
                            Quantity = 2
                        },
                        new
                        {
                            Id = 5,
                            FridgeId = 1,
                            ProductId = 5,
                            Quantity = 6
                        },
                        new
                        {
                            Id = 6,
                            FridgeId = 2,
                            ProductId = 6,
                            Quantity = 12
                        },
                        new
                        {
                            Id = 7,
                            FridgeId = 2,
                            ProductId = 7,
                            Quantity = 8
                        },
                        new
                        {
                            Id = 8,
                            FridgeId = 2,
                            ProductId = 8,
                            Quantity = 4
                        },
                        new
                        {
                            Id = 9,
                            FridgeId = 2,
                            ProductId = 9,
                            Quantity = 3
                        },
                        new
                        {
                            Id = 10,
                            FridgeId = 3,
                            ProductId = 10,
                            Quantity = 15
                        },
                        new
                        {
                            Id = 11,
                            FridgeId = 3,
                            ProductId = 11,
                            Quantity = 10
                        },
                        new
                        {
                            Id = 12,
                            FridgeId = 3,
                            ProductId = 12,
                            Quantity = 7
                        });
                });

            modelBuilder.Entity("WEB_API_Innowise_TestTask.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Products", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Apple",
                            Price = 1.99
                        },
                        new
                        {
                            Id = 2,
                            Name = "Orange",
                            Price = 2.9900000000000002
                        },
                        new
                        {
                            Id = 3,
                            Name = "Banana",
                            Price = 0.98999999999999999
                        },
                        new
                        {
                            Id = 4,
                            Name = "Carrot",
                            Price = 0.79000000000000004
                        },
                        new
                        {
                            Id = 5,
                            Name = "Onion",
                            Price = 0.68999999999999995
                        },
                        new
                        {
                            Id = 6,
                            Name = "Potato",
                            Price = 0.48999999999999999
                        },
                        new
                        {
                            Id = 7,
                            Name = "Egg",
                            Price = 0.28999999999999998
                        },
                        new
                        {
                            Id = 8,
                            Name = "Milk",
                            Price = 3.9900000000000002
                        },
                        new
                        {
                            Id = 9,
                            Name = "Cheese",
                            Price = 4.9900000000000002
                        },
                        new
                        {
                            Id = 10,
                            Name = "Chicken",
                            Price = 6.9900000000000002
                        },
                        new
                        {
                            Id = 11,
                            Name = "Beef",
                            Price = 7.9900000000000002
                        },
                        new
                        {
                            Id = 12,
                            Name = "Pork",
                            Price = 5.9900000000000002
                        });
                });
#pragma warning restore 612, 618
        }
    }
}