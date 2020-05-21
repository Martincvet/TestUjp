﻿// <auto-generated />
using System;
using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Data.Migrations
{
    [DbContext(typeof(UjpDbContext))]
    partial class UjpDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Core.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("TaxReturnPolicy")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Macedonia",
                            TaxReturnPolicy = 0.14999999999999999
                        },
                        new
                        {
                            Id = 2,
                            Name = "USA",
                            TaxReturnPolicy = 0.050000000000000003
                        },
                        new
                        {
                            Id = 3,
                            Name = "Great Britain",
                            TaxReturnPolicy = 0.0050000000000000001
                        });
                });

            modelBuilder.Entity("Core.DDV", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Tax")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("DDVs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Tax = 0.0
                        },
                        new
                        {
                            Id = 2,
                            Tax = 0.050000000000000003
                        },
                        new
                        {
                            Id = 3,
                            Tax = 0.17999999999999999
                        });
                });

            modelBuilder.Entity("Core.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DDVId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int?>("TaxPayerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DDVId");

                    b.HasIndex("TaxPayerId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Core.TaxPayer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CountryId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("TaxPayers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CountryId = 1,
                            FirstName = "Petar",
                            LastName = "Petrevski"
                        },
                        new
                        {
                            Id = 2,
                            CountryId = 1,
                            FirstName = "Igor",
                            LastName = "Igorovski"
                        },
                        new
                        {
                            Id = 3,
                            CountryId = 1,
                            FirstName = "Kire",
                            LastName = "Kocev"
                        },
                        new
                        {
                            Id = 4,
                            CountryId = 1,
                            FirstName = "ALeksandar",
                            LastName = "Aleksandrovski"
                        },
                        new
                        {
                            Id = 5,
                            CountryId = 2,
                            FirstName = "Franklin",
                            LastName = "Short"
                        },
                        new
                        {
                            Id = 6,
                            CountryId = 2,
                            FirstName = "George",
                            LastName = "Wilkerson"
                        },
                        new
                        {
                            Id = 7,
                            CountryId = 2,
                            FirstName = "Kyle",
                            LastName = "McBride"
                        },
                        new
                        {
                            Id = 8,
                            CountryId = 2,
                            FirstName = "Joseph",
                            LastName = "Hudkins"
                        },
                        new
                        {
                            Id = 9,
                            CountryId = 3,
                            FirstName = "Ben",
                            LastName = "Duncan"
                        },
                        new
                        {
                            Id = 10,
                            CountryId = 3,
                            FirstName = "Anthony",
                            LastName = "Marshall"
                        },
                        new
                        {
                            Id = 11,
                            CountryId = 3,
                            FirstName = "Jordan",
                            LastName = "Murray"
                        });
                });

            modelBuilder.Entity("Core.Product", b =>
                {
                    b.HasOne("Core.DDV", "DDV")
                        .WithMany()
                        .HasForeignKey("DDVId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.TaxPayer", null)
                        .WithMany("Products")
                        .HasForeignKey("TaxPayerId");
                });

            modelBuilder.Entity("Core.TaxPayer", b =>
                {
                    b.HasOne("Core.Country", "Country")
                        .WithMany("TaxPayers")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
