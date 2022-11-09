﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using proUserInfoManagement.Api.Data;

#nullable disable

namespace proUserInfoManagement.Api.Migrations
{
    [DbContext(typeof(UserInfoManagementDbContext))]
    partial class UserInfoManagementDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("proUserInfoManagement.Api.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreateDateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ExpireDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("FName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NationalCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PassWord")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateDateTime = new DateTime(2022, 11, 6, 16, 25, 43, 251, DateTimeKind.Local).AddTicks(9665),
                            ExpireDateTime = new DateTime(2025, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FName = "Vahid",
                            LName = "Vosoughi",
                            NationalCode = "123456789",
                            PassWord = "123",
                            UserName = "vahid"
                        },
                        new
                        {
                            Id = 2,
                            CreateDateTime = new DateTime(2022, 11, 6, 16, 25, 43, 251, DateTimeKind.Local).AddTicks(9933),
                            ExpireDateTime = new DateTime(2025, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FName = "Ayoob",
                            LName = "Khani",
                            NationalCode = "123456789",
                            PassWord = "123",
                            UserName = "Ayoob"
                        },
                        new
                        {
                            Id = 3,
                            CreateDateTime = new DateTime(2022, 11, 6, 16, 25, 43, 252, DateTimeKind.Local).AddTicks(18),
                            ExpireDateTime = new DateTime(2025, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FName = "Mehdi",
                            LName = "Hassani",
                            NationalCode = "123456789",
                            PassWord = "123",
                            UserName = "Mehdi"
                        },
                        new
                        {
                            Id = 4,
                            CreateDateTime = new DateTime(2022, 11, 6, 16, 25, 43, 252, DateTimeKind.Local).AddTicks(91),
                            ExpireDateTime = new DateTime(2025, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FName = "Vahid",
                            LName = "Fazeli",
                            NationalCode = "123456789",
                            PassWord = "123",
                            UserName = "vahid1"
                        },
                        new
                        {
                            Id = 5,
                            CreateDateTime = new DateTime(2022, 11, 6, 16, 25, 43, 252, DateTimeKind.Local).AddTicks(164),
                            ExpireDateTime = new DateTime(2025, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FName = "Saeed",
                            LName = "Roshani",
                            NationalCode = "123456789",
                            PassWord = "123",
                            UserName = "Saeed"
                        },
                        new
                        {
                            Id = 6,
                            CreateDateTime = new DateTime(2022, 11, 6, 16, 25, 43, 252, DateTimeKind.Local).AddTicks(250),
                            ExpireDateTime = new DateTime(2025, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FName = "Kazem",
                            LName = "Rahimi",
                            NationalCode = "123456789",
                            PassWord = "123",
                            UserName = "Kazem"
                        },
                        new
                        {
                            Id = 7,
                            CreateDateTime = new DateTime(2022, 11, 6, 16, 25, 43, 252, DateTimeKind.Local).AddTicks(322),
                            ExpireDateTime = new DateTime(2025, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FName = "Ahad",
                            LName = "Mohammadi",
                            NationalCode = "123456789",
                            PassWord = "123",
                            UserName = "Ahad"
                        },
                        new
                        {
                            Id = 8,
                            CreateDateTime = new DateTime(2022, 11, 6, 16, 25, 43, 252, DateTimeKind.Local).AddTicks(390),
                            ExpireDateTime = new DateTime(2025, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FName = "Shahin",
                            LName = "Ahmadi",
                            NationalCode = "123456789",
                            PassWord = "123",
                            UserName = "Shahin"
                        },
                        new
                        {
                            Id = 9,
                            CreateDateTime = new DateTime(2022, 11, 6, 16, 25, 43, 252, DateTimeKind.Local).AddTicks(465),
                            ExpireDateTime = new DateTime(2025, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FName = "Hassan",
                            LName = "Ahmadian",
                            NationalCode = "123456789",
                            PassWord = "123",
                            UserName = "Hassan"
                        },
                        new
                        {
                            Id = 10,
                            CreateDateTime = new DateTime(2022, 11, 6, 16, 25, 43, 252, DateTimeKind.Local).AddTicks(547),
                            ExpireDateTime = new DateTime(2025, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FName = "Mehdi",
                            LName = "Khataei",
                            NationalCode = "123456789",
                            PassWord = "123",
                            UserName = "Mehdi"
                        },
                        new
                        {
                            Id = 11,
                            CreateDateTime = new DateTime(2022, 11, 6, 16, 25, 43, 252, DateTimeKind.Local).AddTicks(621),
                            ExpireDateTime = new DateTime(2025, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FName = "Mehri",
                            LName = "Soltani",
                            NationalCode = "123456789",
                            PassWord = "123",
                            UserName = "Mehri"
                        },
                        new
                        {
                            Id = 12,
                            CreateDateTime = new DateTime(2022, 11, 6, 16, 25, 43, 252, DateTimeKind.Local).AddTicks(692),
                            ExpireDateTime = new DateTime(2025, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FName = "Bahar",
                            LName = "Fakhim",
                            NationalCode = "123456789",
                            PassWord = "123",
                            UserName = "Bahar"
                        },
                        new
                        {
                            Id = 13,
                            CreateDateTime = new DateTime(2022, 11, 6, 16, 25, 43, 252, DateTimeKind.Local).AddTicks(762),
                            ExpireDateTime = new DateTime(2025, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FName = "Laya",
                            LName = "Mostahkam",
                            NationalCode = "123456789",
                            PassWord = "123",
                            UserName = "Laya"
                        },
                        new
                        {
                            Id = 14,
                            CreateDateTime = new DateTime(2022, 11, 6, 16, 25, 43, 252, DateTimeKind.Local).AddTicks(832),
                            ExpireDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FName = "Sajjad",
                            LName = "Vosoughi",
                            NationalCode = "123456789",
                            PassWord = "123",
                            UserName = "Sajjad"
                        },
                        new
                        {
                            Id = 15,
                            CreateDateTime = new DateTime(2022, 11, 6, 16, 25, 43, 252, DateTimeKind.Local).AddTicks(878),
                            ExpireDateTime = new DateTime(2025, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FName = "Ali",
                            LName = "Vosoughi",
                            NationalCode = "123456789",
                            PassWord = "123",
                            UserName = "Ali"
                        },
                        new
                        {
                            Id = 16,
                            CreateDateTime = new DateTime(2022, 11, 6, 16, 25, 43, 252, DateTimeKind.Local).AddTicks(947),
                            ExpireDateTime = new DateTime(2025, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FName = "Vida",
                            LName = "Soltani",
                            NationalCode = "123456789",
                            PassWord = "123",
                            UserName = "Vida"
                        },
                        new
                        {
                            Id = 17,
                            CreateDateTime = new DateTime(2022, 11, 6, 16, 25, 43, 252, DateTimeKind.Local).AddTicks(1017),
                            ExpireDateTime = new DateTime(2025, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FName = "Yunes",
                            LName = "MohamadZadeh",
                            NationalCode = "123456789",
                            PassWord = "123",
                            UserName = "Yunes"
                        },
                        new
                        {
                            Id = 18,
                            CreateDateTime = new DateTime(2022, 11, 6, 16, 25, 43, 252, DateTimeKind.Local).AddTicks(1096),
                            ExpireDateTime = new DateTime(2025, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FName = "Sahand",
                            LName = "Asghari",
                            NationalCode = "123456789",
                            PassWord = "123",
                            UserName = "Sahand"
                        },
                        new
                        {
                            Id = 19,
                            CreateDateTime = new DateTime(2022, 11, 6, 16, 25, 43, 252, DateTimeKind.Local).AddTicks(1369),
                            ExpireDateTime = new DateTime(2025, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FName = "Firuz",
                            LName = "Kazemi",
                            NationalCode = "123456789",
                            PassWord = "123",
                            UserName = "Firuz"
                        },
                        new
                        {
                            Id = 20,
                            CreateDateTime = new DateTime(2022, 11, 6, 16, 25, 43, 252, DateTimeKind.Local).AddTicks(1468),
                            ExpireDateTime = new DateTime(2025, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FName = "Mohammad",
                            LName = "Shakeri",
                            NationalCode = "123456789",
                            PassWord = "123",
                            UserName = "Mohammad"
                        },
                        new
                        {
                            Id = 21,
                            CreateDateTime = new DateTime(2022, 11, 6, 16, 25, 43, 252, DateTimeKind.Local).AddTicks(1535),
                            ExpireDateTime = new DateTime(2025, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FName = "Akram",
                            LName = "Jahanbakhsh",
                            NationalCode = "123456789",
                            PassWord = "123",
                            UserName = "Akram"
                        },
                        new
                        {
                            Id = 22,
                            CreateDateTime = new DateTime(2022, 11, 6, 16, 25, 43, 252, DateTimeKind.Local).AddTicks(1596),
                            ExpireDateTime = new DateTime(2025, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FName = "Zahra",
                            LName = "Dadashzadeh",
                            NationalCode = "123456789",
                            PassWord = "123",
                            UserName = "Zahra"
                        },
                        new
                        {
                            Id = 23,
                            CreateDateTime = new DateTime(2022, 11, 6, 16, 25, 43, 252, DateTimeKind.Local).AddTicks(1662),
                            ExpireDateTime = new DateTime(2025, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FName = "Davood",
                            LName = "Soltani",
                            NationalCode = "123456789",
                            PassWord = "123",
                            UserName = "Davood"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}