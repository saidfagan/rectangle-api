﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RectangleApi.Data;

#nullable disable

namespace RectangleApi.Migrations
{
    [DbContext(typeof(RectangleContext))]
    [Migration("20240508070849_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.4");

            modelBuilder.Entity("RectangleApi.Data.RectangleEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("Height")
                        .HasColumnType("REAL");

                    b.Property<double>("Width")
                        .HasColumnType("REAL");

                    b.Property<double>("X")
                        .HasColumnType("REAL");

                    b.Property<double>("Y")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("Rectangles");
                });
#pragma warning restore 612, 618
        }
    }
}
