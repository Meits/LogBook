﻿using Microsoft.EntityFrameworkCore;
using Logbook.Entities;
using System;
using System.Collections.Generic;

namespace Logbook.AppContext
{
    public class AppDbContext : DbContext
    {
        public DbSet<Faculty> Faculties { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<Mark> Mark { get; set; }
        public DbSet<TeacherSubject> TeacherSubjects { get; set; }
        

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Faculty>().HasData(
                new Faculty
                {
                    Id = Guid.NewGuid(),
                    Name = "Programming",

                },
                new Faculty
                {
                    Id = Guid.NewGuid(),
                    Name = "System administration and security",

                },
                new Faculty
                {
                    Id = Guid.NewGuid(),
                    Name = "Disign",

                },
                new Faculty
                {
                    Id = Guid.NewGuid(),
                    Name = "Base",

                });
        }
    }
}
