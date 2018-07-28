﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication.Data;

namespace WebApplication.Data.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20180728175239_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApplication.Core.Entities.Users", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Avatar")
                        .HasMaxLength(200);

                    b.Property<bool>("ChangeProfile");

                    b.Property<string>("CreationDate")
                        .HasMaxLength(10);

                    b.Property<string>("EditDate")
                        .HasMaxLength(10);

                    b.Property<string>("Family")
                        .HasMaxLength(50);

                    b.Property<string>("FullName")
                        .HasMaxLength(101);

                    b.Property<bool>("IsActive");

                    b.Property<string>("Name")
                        .HasMaxLength(50);

                    b.Property<string>("Password")
                        .HasMaxLength(20);

                    b.Property<string>("UserName")
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
