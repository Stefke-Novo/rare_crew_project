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
    [Migration("20231224033613_RenamingHousWorkedColumn")]
    partial class RenamingHousWorkedColumn
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
                        .HasColumnName("id")
                        .HasAnnotation("Relational:JsonPropertyName", "Id");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2")
                        .HasColumnName("deleted_on")
                        .HasAnnotation("Relational:JsonPropertyName", "DeletedOn");

                    b.Property<DateTime>("EndTimeUTC")
                        .HasColumnType("datetime2")
                        .HasColumnName("end_time_utc")
                        .HasAnnotation("Relational:JsonPropertyName", "EndTimeUtc");

                    b.Property<string>("EntryNotes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("entry_notes")
                        .HasAnnotation("Relational:JsonPropertyName", "EntryNotes");

                    b.Property<int>("HoursWorked")
                        .HasColumnType("int")
                        .HasColumnName("hours_worked");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("name")
                        .HasAnnotation("Relational:JsonPropertyName", "EmployeeName");

                    b.Property<DateTime>("StartTimeUTC")
                        .HasColumnType("datetime2")
                        .HasColumnName("start_time_utc")
                        .HasAnnotation("Relational:JsonPropertyName", "StarTimeUtc");

                    b.HasKey("Id");

                    b.ToTable("employee_data");
                });
#pragma warning restore 612, 618
        }
    }
}
