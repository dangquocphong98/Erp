﻿// <auto-generated />
using System;
using Erp.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Erp.Model.Migrations
{
    [DbContext(typeof(ErpContext))]
    partial class ErpContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Erp.Model.Entity.Staff", b =>
                {
                    b.Property<string>("Id_Staff")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("AttendanceCode")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("Birth")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("CodeMachine")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Email")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("PassWord")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Phone")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("UserName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id_Staff");

                    b.ToTable("Staffs");
                });

            modelBuilder.Entity("Erp.Model.Entity.Timekeeper", b =>
                {
                    b.Property<string>("CodeMachine")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("CodeMachine");

                    b.ToTable("Timekeepers");
                });

            modelBuilder.Entity("Erp.Model.Entity.TimekeepingHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("ArrivalTime")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("BackTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("CodeMachine")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("CodeStaff")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("IsTrue")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("LateTime")
                        .HasColumnType("int");

                    b.Property<string>("LateTimeType")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("TimekeepingHistories");
                });
#pragma warning restore 612, 618
        }
    }
}
