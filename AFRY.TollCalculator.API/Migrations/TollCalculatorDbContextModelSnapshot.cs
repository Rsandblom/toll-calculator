﻿// <auto-generated />
using System;
using AFRY.TollCalculator.API.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AFRY.TollCalculator.API.Migrations
{
    [DbContext(typeof(TollCalculatorDbContext))]
    partial class TollCalculatorDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AFRY.TollCalculator.API.Domain.Entities.TollFeePeriod", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<TimeSpan>("EndTime")
                        .HasColumnType("time");

                    b.Property<decimal>("Fee")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<TimeSpan>("StartTime")
                        .HasColumnType("time");

                    b.HasKey("Id");

                    b.ToTable("TollFeePeriods");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = "",
                            EndTime = new TimeSpan(0, 6, 29, 59, 0),
                            Fee = 8m,
                            StartTime = new TimeSpan(0, 6, 0, 0, 0)
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = "",
                            EndTime = new TimeSpan(0, 6, 59, 59, 0),
                            Fee = 13m,
                            StartTime = new TimeSpan(0, 6, 30, 0, 0)
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = "",
                            EndTime = new TimeSpan(0, 7, 59, 59, 0),
                            Fee = 18m,
                            StartTime = new TimeSpan(0, 7, 0, 0, 0)
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = "",
                            EndTime = new TimeSpan(0, 8, 29, 59, 0),
                            Fee = 13m,
                            StartTime = new TimeSpan(0, 8, 0, 0, 0)
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = "",
                            EndTime = new TimeSpan(0, 14, 59, 59, 0),
                            Fee = 8m,
                            StartTime = new TimeSpan(0, 8, 30, 0, 0)
                        },
                        new
                        {
                            Id = 6,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = "",
                            EndTime = new TimeSpan(0, 15, 29, 59, 0),
                            Fee = 13m,
                            StartTime = new TimeSpan(0, 15, 0, 0, 0)
                        },
                        new
                        {
                            Id = 7,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = "",
                            EndTime = new TimeSpan(0, 16, 59, 59, 0),
                            Fee = 18m,
                            StartTime = new TimeSpan(0, 15, 30, 0, 0)
                        },
                        new
                        {
                            Id = 8,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = "",
                            EndTime = new TimeSpan(0, 17, 59, 59, 0),
                            Fee = 13m,
                            StartTime = new TimeSpan(0, 17, 0, 0, 0)
                        },
                        new
                        {
                            Id = 9,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = "",
                            EndTime = new TimeSpan(0, 18, 29, 59, 0),
                            Fee = 8m,
                            StartTime = new TimeSpan(0, 18, 0, 0, 0)
                        });
                });

            modelBuilder.Entity("AFRY.TollCalculator.API.Domain.Entities.TollFreeDate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TollFreeDates");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Date = new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "New Year's Day"
                        },
                        new
                        {
                            Id = 2,
                            Date = new DateTime(2013, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Good Friday"
                        },
                        new
                        {
                            Id = 3,
                            Date = new DateTime(2013, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Easter Monday"
                        },
                        new
                        {
                            Id = 4,
                            Date = new DateTime(2013, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Holiday"
                        },
                        new
                        {
                            Id = 5,
                            Date = new DateTime(2013, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Holiday"
                        },
                        new
                        {
                            Id = 6,
                            Date = new DateTime(2013, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Labor Day"
                        },
                        new
                        {
                            Id = 7,
                            Date = new DateTime(2013, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Holiday"
                        },
                        new
                        {
                            Id = 8,
                            Date = new DateTime(2013, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Holiday"
                        },
                        new
                        {
                            Id = 9,
                            Date = new DateTime(2013, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Holiday"
                        },
                        new
                        {
                            Id = 10,
                            Date = new DateTime(2013, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Holiday"
                        },
                        new
                        {
                            Id = 11,
                            Date = new DateTime(2013, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Holiday"
                        },
                        new
                        {
                            Id = 12,
                            Date = new DateTime(2013, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Holiday"
                        },
                        new
                        {
                            Id = 13,
                            Date = new DateTime(2013, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Christmas Eve"
                        },
                        new
                        {
                            Id = 14,
                            Date = new DateTime(2013, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Christmas Day"
                        },
                        new
                        {
                            Id = 15,
                            Date = new DateTime(2013, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Boxing Day"
                        },
                        new
                        {
                            Id = 16,
                            Date = new DateTime(2013, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "New Year's Eve"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
