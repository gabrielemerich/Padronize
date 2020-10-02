﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Padronize.Data;

namespace Padronize.Migrations
{
    [DbContext(typeof(StoreDataContext))]
    [Migration("20200301150009_PadronizeV1")]
    partial class PadronizeV1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Padronize.Models.Application", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("description")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int?>("projectid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("projectid");

                    b.ToTable("Application");
                });

            modelBuilder.Entity("Padronize.Models.Image", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("Standartid")
                        .HasColumnType("int");

                    b.Property<string>("text")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<double>("x")
                        .HasColumnType("double");

                    b.Property<double>("y")
                        .HasColumnType("double");

                    b.HasKey("id");

                    b.HasIndex("Standartid");

                    b.ToTable("Image");
                });

            modelBuilder.Entity("Padronize.Models.Project", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("description")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("title")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("id");

                    b.ToTable("Project");
                });

            modelBuilder.Entity("Padronize.Models.Standart", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("code_example")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("description")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("title")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("id");

                    b.ToTable("Standart");
                });

            modelBuilder.Entity("Padronize.Models.Application", b =>
                {
                    b.HasOne("Padronize.Models.Project", "project")
                        .WithMany("applications")
                        .HasForeignKey("projectid");
                });

            modelBuilder.Entity("Padronize.Models.Image", b =>
                {
                    b.HasOne("Padronize.Models.Standart", null)
                        .WithMany("images")
                        .HasForeignKey("Standartid");
                });
#pragma warning restore 612, 618
        }
    }
}