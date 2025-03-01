using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Assignment1_C_.Models;
using Microsoft.EntityFrameworkCore;

namespace Assignment1_C_
{
    public class ITIDbContext : DbContext
    {
        //public DbSet<>
        public DbSet<Student> Students { get; set; }
        public DbSet<Student_Course> Student_Courses { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<Course_Inst> Course_Insts { get; set; }
        public DbSet<Instructor> Instructors { get; set; }

        // Connection String
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=AHMEDSHAABAN;database=ITIDatabase;trusted_connection=true;trustServerCertificate=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuration Class
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            // Fluent Api
            modelBuilder.Entity<Student>().HasKey(x => x.StudentId);
            modelBuilder.Entity<Student>().Property(x => x.StudentId).UseIdentityColumn(10, 10);

            modelBuilder.Entity<Student>().Property(x => x.FirstName).IsRequired()
                                           .HasColumnName("Student FristName")
                                           .HasColumnType("varchar(50)");

            modelBuilder.Entity<Student>().Property(x => x.Address).HasDefaultValue("Cairo");


            modelBuilder.Entity<Student>().HasIndex(x => x.Age).IsUnique();
        }
    }
}
