﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using ShopApp.Context;

namespace ShopApp.Migrations
{
    [DbContext(typeof(ShopContext))]
    [Migration("20191216053507_Fix6")]
    partial class Fix6
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("ShopApp.Models.Basket", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<bool>("HasPaid")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.ToTable("Baskets");

                    b.HasData(
                        new
                        {
                            Id = new Guid("b1b34c78-ddda-4659-81be-975aa9019174"),
                            HasPaid = false
                        });
                });

            modelBuilder.Entity("ShopApp.Models.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid?>("BasketId")
                        .HasColumnType("uuid");

                    b.Property<int>("Cost")
                        .HasColumnType("integer");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("BasketId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = new Guid("3ce707f5-b77e-459f-849e-390cca47a0dd"),
                            Cost = 1000,
                            Description = "Белая корова",
                            Name = "Корова"
                        },
                        new
                        {
                            Id = new Guid("a1747698-7a56-4c6b-8bdc-c3506e62e06e"),
                            Cost = 100,
                            Description = "Белый хлеб",
                            Name = "Хлеб"
                        },
                        new
                        {
                            Id = new Guid("f8837dba-5e8e-4c66-a035-11a4db797cdf"),
                            Cost = 250,
                            Description = "Коровье",
                            Name = "Молоко"
                        });
                });

            modelBuilder.Entity("ShopApp.Models.Product", b =>
                {
                    b.HasOne("ShopApp.Models.Basket", "Basket")
                        .WithMany("Products")
                        .HasForeignKey("BasketId");
                });
#pragma warning restore 612, 618
        }
    }
}
