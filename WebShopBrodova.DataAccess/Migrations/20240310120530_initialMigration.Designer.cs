﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebShopBrodova.DataAccess.Data;

#nullable disable

namespace WebShopBrodova.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240310120530_initialMigration")]
    partial class initialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebShopBrodova.Models.TypeBoat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("TypesOfBoats");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DisplayOrder = 1,
                            ImageUrl = "https://as1.ftcdn.net/v2/jpg/01/24/27/30/1000_F_124273079_ZHuBjV9p2Im0LZYcKH82C6bcaQrjRxtq.jpg",
                            Name = "Motor boats"
                        },
                        new
                        {
                            Id = 2,
                            DisplayOrder = 2,
                            ImageUrl = "https://www.bavariayachts.com/fileadmin/_processed_/2/7/csm_bavaria-sy-cruiserline-overview-cruiser37_8a9c47d54f.jpg",
                            Name = "Sailing boats"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
