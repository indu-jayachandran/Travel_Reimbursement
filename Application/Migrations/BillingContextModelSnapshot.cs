﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Application.Migrations
{
    [DbContext(typeof(BillingContext))]
    partial class BillingContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BillPropert", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Bill_File")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Bill_Number")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("Date_of_Return")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Date_of_Visit")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Date_on_Bill")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Expense")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Purpose_of_Visit")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Travel_By")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Visited_Palce")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("vehicle_Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("BillProperts");
                });
#pragma warning restore 612, 618
        }
    }
}
