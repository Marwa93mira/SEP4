﻿// <auto-generated />
using System;
using EfcDataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EfcDataAccess.Migrations
{
    [DbContext(typeof(HospitalContext))]
    [Migration("20230328180216_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.4");

            modelBuilder.Entity("Domain.Models.Patient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("RoomId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("RoomId");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("Domain.Models.Room", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Availability")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Capacity")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("Domain.Models.Sensor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double?>("DownBreakpoint")
                        .HasColumnType("REAL");

                    b.Property<int?>("RoomId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double?>("UpBreakpoint")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.HasIndex("RoomId");

                    b.ToTable("Sensors");
                });

            modelBuilder.Entity("Domain.Models.SensorValue", b =>
                {
                    b.Property<int>("valueId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("SensorId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("timeStamp")
                        .HasColumnType("TEXT");

                    b.Property<double>("value")
                        .HasColumnType("REAL");

                    b.HasKey("valueId");

                    b.HasIndex("SensorId");

                    b.ToTable("SensorValue");
                });

            modelBuilder.Entity("Domain.Models.Patient", b =>
                {
                    b.HasOne("Domain.Models.Room", null)
                        .WithMany("Patients")
                        .HasForeignKey("RoomId");
                });

            modelBuilder.Entity("Domain.Models.Sensor", b =>
                {
                    b.HasOne("Domain.Models.Room", null)
                        .WithMany("Sensors")
                        .HasForeignKey("RoomId");
                });

            modelBuilder.Entity("Domain.Models.SensorValue", b =>
                {
                    b.HasOne("Domain.Models.Sensor", null)
                        .WithMany("Values")
                        .HasForeignKey("SensorId");
                });

            modelBuilder.Entity("Domain.Models.Room", b =>
                {
                    b.Navigation("Patients");

                    b.Navigation("Sensors");
                });

            modelBuilder.Entity("Domain.Models.Sensor", b =>
                {
                    b.Navigation("Values");
                });
#pragma warning restore 612, 618
        }
    }
}
