﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Sales.API.Data;

#nullable disable

namespace Sales.API.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230310052711_AddIdStatsAnCity")]
    partial class AddIdStatsAnCity
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Sales.Shared.Entities.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("StateId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("StateId1")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StateId1");

                    b.HasIndex("StateId", "Name")
                        .IsUnique();

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("Sales.Shared.Entities.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("Sales.Shared.Entities.State", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("CountryId", "Name")
                        .IsUnique();

                    b.ToTable("States");
                });

            modelBuilder.Entity("Sales.Shared.Entities.City", b =>
                {
                    b.HasOne("Sales.Shared.Entities.State", "State")
                        .WithMany("Cities")
                        .HasForeignKey("StateId1");

                    b.Navigation("State");
                });

            modelBuilder.Entity("Sales.Shared.Entities.State", b =>
                {
                    b.HasOne("Sales.Shared.Entities.Country", "Country")
                        .WithMany("States")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("Sales.Shared.Entities.Country", b =>
                {
                    b.Navigation("States");
                });

            modelBuilder.Entity("Sales.Shared.Entities.State", b =>
                {
                    b.Navigation("Cities");
                });
#pragma warning restore 612, 618
        }
    }
}
