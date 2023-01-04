﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Points.API.Models;

#nullable disable

namespace Points.API.Migrations
{
    [DbContext(typeof(PointsDbContext))]
    [Migration("20221206020034_changeDBStructure")]
    partial class changeDBStructure
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Points.Shared.Models.Module", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Channels")
                        .HasColumnType("int");

                    b.Property<double>("MaxCnts")
                        .HasColumnType("float");

                    b.Property<double>("MinCnts")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Signal")
                        .HasColumnType("int");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Module");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Channels = 2,
                            MaxCnts = 32764.0,
                            MinCnts = 0.0,
                            Name = "750-550",
                            Signal = 1,
                            Type = 1
                        },
                        new
                        {
                            Id = 2,
                            Channels = 2,
                            MaxCnts = 32767.0,
                            MinCnts = -32767.0,
                            Name = "750-556",
                            Signal = 1,
                            Type = 1
                        },
                        new
                        {
                            Id = 3,
                            Channels = 2,
                            MaxCnts = 32767.0,
                            MinCnts = 0.0,
                            Name = "750-552",
                            Signal = 2,
                            Type = 1
                        },
                        new
                        {
                            Id = 4,
                            Channels = 2,
                            MaxCnts = 0.0,
                            MinCnts = 0.0,
                            Name = "750-400",
                            Signal = 2,
                            Type = 2
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
