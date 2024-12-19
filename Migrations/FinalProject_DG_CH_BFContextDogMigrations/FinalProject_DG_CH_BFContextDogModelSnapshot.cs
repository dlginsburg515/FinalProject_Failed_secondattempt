﻿// <auto-generated />
using System;
using FinalProject_DG_CH_BF.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FinalProject_DG_CH_BF.Migrations.FinalProject_DG_CH_BFContextDogMigrations
{
    [DbContext(typeof(FinalProject_DG_CH_BFContextDog))]
    partial class FinalProject_DG_CH_BFContextDogModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FinalProject_DG_CH_BF.Models.Dog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Breed")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateOnly>("DateArrived")
                        .HasColumnType("date");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("GoodWithCats")
                        .HasColumnType("bit");

                    b.Property<bool>("GoodWithDogs")
                        .HasColumnType("bit");

                    b.Property<bool>("GoodWithKids")
                        .HasColumnType("bit");

                    b.Property<string>("HealthStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Height")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Weight")
                        .HasColumnType("float");

                    b.Property<string>("imageName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Dog");
                });
#pragma warning restore 612, 618
        }
    }
}
