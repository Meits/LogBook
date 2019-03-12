﻿// <auto-generated />
using System;
using Logbook.AppContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LogBookWeb.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20190312194817_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Logbook.Entities.Faculty", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .HasColumnName("name")
                        .HasMaxLength(64);

                    b.HasKey("Id");

                    b.ToTable("faculties");

                    b.HasData(
                        new
                        {
                            Id = new Guid("00aed207-c831-4cb1-bdb5-815794da4427"),
                            Name = "Programming"
                        },
                        new
                        {
                            Id = new Guid("97cdace3-a2a1-4bb5-bb55-8423e73dfce7"),
                            Name = "System administration and security"
                        },
                        new
                        {
                            Id = new Guid("8128d163-d737-4831-b7fc-cf266a7b2f54"),
                            Name = "Disign"
                        },
                        new
                        {
                            Id = new Guid("148fe329-1968-4674-8060-81f79a5f55f2"),
                            Name = "Base"
                        });
                });

            modelBuilder.Entity("Logbook.Entities.Group", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("FacultyId");

                    b.Property<string>("Name")
                        .HasColumnName("name")
                        .HasMaxLength(64);

                    b.HasKey("Id");

                    b.HasIndex("FacultyId");

                    b.ToTable("groups");
                });

            modelBuilder.Entity("Logbook.Entities.Student", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FirstName")
                        .HasColumnName("firstName")
                        .HasMaxLength(64);

                    b.Property<Guid?>("GroupId");

                    b.Property<string>("LastName")
                        .HasColumnName("lastName")
                        .HasMaxLength(64);

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.ToTable("students");
                });

            modelBuilder.Entity("Logbook.Entities.Group", b =>
                {
                    b.HasOne("Logbook.Entities.Faculty", "Faculty")
                        .WithMany("Groups")
                        .HasForeignKey("FacultyId");
                });

            modelBuilder.Entity("Logbook.Entities.Student", b =>
                {
                    b.HasOne("Logbook.Entities.Group", "Group")
                        .WithMany("Students")
                        .HasForeignKey("GroupId");
                });
#pragma warning restore 612, 618
        }
    }
}