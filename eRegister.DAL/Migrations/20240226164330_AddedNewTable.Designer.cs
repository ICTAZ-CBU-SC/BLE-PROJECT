﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using eRegister.DAL.Models;

#nullable disable

namespace eRegister.DAL.Migrations
{
    [DbContext(typeof(ERegisterDbContext))]
    [Migration("20240226164330_AddedNewTable")]
    partial class AddedNewTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.2");

            modelBuilder.Entity("eRegister.DAL.Models.Attendance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CourseCode")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("DateAttended")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("DepartmentCode")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("IsPresent")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ProgrammeCode")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SchoolCode")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Sin")
                        .HasColumnType("INTEGER")
                        .HasColumnName("SIN");

                    b.HasKey("Id");

                    b.ToTable("Attendance", (string)null);
                });

            modelBuilder.Entity("eRegister.Shared.Student", b =>
                {
                    b.Property<int>("SIN")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<Guid>("DeviceAddress")
                        .HasColumnType("TEXT");

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Middlename")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ProgCode")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ProgDescription")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("SIN");

                    b.ToTable("Students");
                });
#pragma warning restore 612, 618
        }
    }
}
