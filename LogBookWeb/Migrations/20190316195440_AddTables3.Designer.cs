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
    [Migration("20190316195440_AddTables3")]
    partial class AddTables3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Logbook.Entities.AcademicSubject", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("TeacherId");

                    b.Property<string>("Title")
                        .HasColumnName("title")
                        .HasMaxLength(64);

                    b.HasKey("Id");

                    b.HasIndex("TeacherId");

                    b.ToTable("academic_subjects");
                });

            modelBuilder.Entity("Logbook.Entities.Department", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Title")
                        .HasColumnName("name")
                        .HasMaxLength(64);

                    b.HasKey("Id");

                    b.ToTable("departments");
                });

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
                            Id = new Guid("33676bde-7055-4cb6-b5b6-b2f36365a3f0"),
                            Name = "Programming"
                        },
                        new
                        {
                            Id = new Guid("e3a52eb7-647d-4539-b75b-16233f57098b"),
                            Name = "System administration and security"
                        },
                        new
                        {
                            Id = new Guid("d7439330-9457-4f5c-887e-f3c34f15624b"),
                            Name = "Disign"
                        },
                        new
                        {
                            Id = new Guid("0726d4c1-62da-4ac6-9034-078b8c388d69"),
                            Name = "Base"
                        });
                });

            modelBuilder.Entity("Logbook.Entities.Group", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("FacultyId");

                    b.Property<Guid>("FacultytId");

                    b.Property<string>("Name")
                        .HasColumnName("name")
                        .HasMaxLength(64);

                    b.HasKey("Id");

                    b.HasIndex("FacultyId");

                    b.ToTable("groups");
                });

            modelBuilder.Entity("Logbook.Entities.Mark", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("StudentId");

                    b.Property<Guid>("TeacherSubjectId");

                    b.Property<string>("Value")
                        .HasColumnName("value")
                        .HasMaxLength(64);

                    b.HasKey("Id");

                    b.HasIndex("StudentId");

                    b.HasIndex("TeacherSubjectId");

                    b.ToTable("marks");
                });

            modelBuilder.Entity("Logbook.Entities.Student", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FirstName")
                        .HasColumnName("firstName")
                        .HasMaxLength(64);

                    b.Property<Guid>("GroupId");

                    b.Property<string>("LastName")
                        .HasColumnName("lastName")
                        .HasMaxLength(64);

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.ToTable("students");
                });

            modelBuilder.Entity("Logbook.Entities.Subject", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Title")
                        .HasColumnName("name")
                        .HasMaxLength(64);

                    b.HasKey("Id");

                    b.ToTable("subjects");
                });

            modelBuilder.Entity("Logbook.Entities.Teacher", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("DepartmentId");

                    b.Property<string>("FirstName")
                        .HasColumnName("firstName")
                        .HasMaxLength(64);

                    b.Property<string>("LastName")
                        .HasColumnName("lastName")
                        .HasMaxLength(64);

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("teachers");
                });

            modelBuilder.Entity("Logbook.Entities.TeacherSubject", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("SubjectId");

                    b.Property<Guid>("TeacherId");

                    b.HasKey("Id");

                    b.HasIndex("SubjectId");

                    b.HasIndex("TeacherId");

                    b.ToTable("TeacherSubjects");
                });

            modelBuilder.Entity("Logbook.Entities.AcademicSubject", b =>
                {
                    b.HasOne("Logbook.Entities.Teacher", "Teacher")
                        .WithMany("AcademicSubjects")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Logbook.Entities.Group", b =>
                {
                    b.HasOne("Logbook.Entities.Faculty", "Faculty")
                        .WithMany("Groups")
                        .HasForeignKey("FacultyId");
                });

            modelBuilder.Entity("Logbook.Entities.Mark", b =>
                {
                    b.HasOne("Logbook.Entities.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Logbook.Entities.TeacherSubject", "TeacherSubject")
                        .WithMany()
                        .HasForeignKey("TeacherSubjectId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Logbook.Entities.Student", b =>
                {
                    b.HasOne("Logbook.Entities.Group", "Group")
                        .WithMany("Students")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Logbook.Entities.Teacher", b =>
                {
                    b.HasOne("Logbook.Entities.Department", "Department")
                        .WithMany("Teachers")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Logbook.Entities.TeacherSubject", b =>
                {
                    b.HasOne("Logbook.Entities.Subject", "Subject")
                        .WithMany()
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Logbook.Entities.Teacher", "Teacher")
                        .WithMany()
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
