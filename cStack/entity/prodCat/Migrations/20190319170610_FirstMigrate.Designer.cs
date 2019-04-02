﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using prodCat.Models;

namespace prodCat.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20190319170610_FirstMigrate")]
    partial class FirstMigrate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("prodCat.Models.Association", b =>
                {
                    b.Property<int>("associationId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("categoryId");

                    b.Property<int>("productId");

                    b.HasKey("associationId");

                    b.HasIndex("categoryId");

                    b.HasIndex("productId");

                    b.ToTable("Associations");
                });

            modelBuilder.Entity("prodCat.Models.Category", b =>
                {
                    b.Property<int>("categoryId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<DateTime>("UpdatedAt");

                    b.Property<string>("name")
                        .IsRequired();

                    b.HasKey("categoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("prodCat.Models.Product", b =>
                {
                    b.Property<int>("productId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<DateTime>("UpdatedAt");

                    b.Property<string>("desc")
                        .IsRequired();

                    b.Property<string>("name")
                        .IsRequired();

                    b.Property<decimal>("price");

                    b.HasKey("productId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("prodCat.Models.Association", b =>
                {
                    b.HasOne("prodCat.Models.Category", "category")
                        .WithMany()
                        .HasForeignKey("categoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("prodCat.Models.Product", "product")
                        .WithMany()
                        .HasForeignKey("productId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}