﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using crm.Models;

namespace crm.Migrations
{
    [DbContext(typeof(CurrencyDB))]
    [Migration("20220114034347_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("crm.Models.Currency", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("created_at")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ghosted")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("is_sync")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("rate")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("symbol")
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("updated_at")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("id");

                    b.ToTable("Currency");
                });
#pragma warning restore 612, 618
        }
    }
}
