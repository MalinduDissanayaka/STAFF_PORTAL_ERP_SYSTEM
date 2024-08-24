﻿// <auto-generated />
using System;
using ERP.ResultManagement.DataServices;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ERP.ResultManagement.DataServices.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.6");

            modelBuilder.Entity("ERP.ResultManagement.Core.Entities.ComResults", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("AddedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("CE0001")
                        .HasColumnType("TEXT");

                    b.Property<string>("CE0002")
                        .HasColumnType("TEXT");

                    b.Property<string>("CE0003")
                        .HasColumnType("TEXT");

                    b.Property<string>("CE0004")
                        .HasColumnType("TEXT");

                    b.Property<string>("CE0005")
                        .HasColumnType("TEXT");

                    b.Property<string>("CE0006")
                        .HasColumnType("TEXT");

                    b.Property<string>("CE0007")
                        .HasColumnType("TEXT");

                    b.Property<string>("CE0008")
                        .HasColumnType("TEXT");

                    b.Property<string>("CE0009")
                        .HasColumnType("TEXT");

                    b.Property<string>("CE0010")
                        .HasColumnType("TEXT");

                    b.Property<string>("CE0011")
                        .HasColumnType("TEXT");

                    b.Property<string>("CE0012")
                        .HasColumnType("TEXT");

                    b.Property<int>("ComId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Status")
                        .HasColumnType("INTEGER");

                    b.Property<string>("StudentName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("ComResults");
                });

            modelBuilder.Entity("ERP.ResultManagement.Core.Entities.DeieResults", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("AddedDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("DEIEid")
                        .HasColumnType("INTEGER");

                    b.Property<string>("EE0001")
                        .HasColumnType("TEXT");

                    b.Property<string>("EE0002")
                        .HasColumnType("TEXT");

                    b.Property<string>("EE0003")
                        .HasColumnType("TEXT");

                    b.Property<string>("EE0004")
                        .HasColumnType("TEXT");

                    b.Property<string>("EE0005")
                        .HasColumnType("TEXT");

                    b.Property<string>("EE0006")
                        .HasColumnType("TEXT");

                    b.Property<string>("EE0007")
                        .HasColumnType("TEXT");

                    b.Property<string>("EE0008")
                        .HasColumnType("TEXT");

                    b.Property<string>("EE0009")
                        .HasColumnType("TEXT");

                    b.Property<string>("EE0010")
                        .HasColumnType("TEXT");

                    b.Property<string>("EE0011")
                        .HasColumnType("TEXT");

                    b.Property<string>("EE0012")
                        .HasColumnType("TEXT");

                    b.Property<int>("Status")
                        .HasColumnType("INTEGER");

                    b.Property<string>("StudentName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("DeieResults");
                });
#pragma warning restore 612, 618
        }
    }
}
