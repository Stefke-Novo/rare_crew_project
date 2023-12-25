﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ServerApp;

#nullable disable

namespace ServerApp.Migrations
{
    [DbContext(typeof(DBContext))]
    [Migration("20231223221132_CreatingEmployeeTable")]
    partial class CreatingEmployeeTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ServerApp.Models.Employee", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(36)
                        .HasColumnType("nvarchar(36)")
                        .HasColumnName("id");

                    b.Property<DateTime>("DeletedOn")
                        .HasColumnType("datetime2")
                        .HasColumnName("deleted_on");

                    b.Property<DateTime>("EndTimeUTC")
                        .HasColumnType("datetime2")
                        .HasColumnName("end_time_utc");

                    b.Property<string>("EntryNotes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("entry_notes");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("name");

                    b.Property<DateTime>("StartTimeUTC")
                        .HasColumnType("datetime2")
                        .HasColumnName("start_time_utc");

                    b.HasKey("Id");

                    b.ToTable("employee");
                });
#pragma warning restore 612, 618
        }
    }
}