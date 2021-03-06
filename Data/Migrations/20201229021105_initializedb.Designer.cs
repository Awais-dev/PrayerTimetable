﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PrayerTimes.Data;

namespace PrayerTimes.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20201229021105_initializedb")]
    partial class initializedb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PrayerTimes.Models.Prayer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Jamat")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Start")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Prayer");
                });

            modelBuilder.Entity("PrayerTimes.Models.PrayerTimetable", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("AsrId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Day")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("DhuhrId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("FajrId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IshaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("MaghribId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Month")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Sunrise")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AsrId");

                    b.HasIndex("DhuhrId");

                    b.HasIndex("FajrId");

                    b.HasIndex("IshaId");

                    b.HasIndex("MaghribId");

                    b.ToTable("PrayerTimetable");
                });

            modelBuilder.Entity("PrayerTimes.Models.PrayerTimetable", b =>
                {
                    b.HasOne("PrayerTimes.Models.Prayer", "Asr")
                        .WithMany()
                        .HasForeignKey("AsrId");

                    b.HasOne("PrayerTimes.Models.Prayer", "Dhuhr")
                        .WithMany()
                        .HasForeignKey("DhuhrId");

                    b.HasOne("PrayerTimes.Models.Prayer", "Fajr")
                        .WithMany()
                        .HasForeignKey("FajrId");

                    b.HasOne("PrayerTimes.Models.Prayer", "Isha")
                        .WithMany()
                        .HasForeignKey("IshaId");

                    b.HasOne("PrayerTimes.Models.Prayer", "Maghrib")
                        .WithMany()
                        .HasForeignKey("MaghribId");
                });
#pragma warning restore 612, 618
        }
    }
}
