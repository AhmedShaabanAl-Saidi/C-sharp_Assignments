using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment1_C_.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Assignment1_C_.Configurations
{
    public class Student_CourseConfigurations : IEntityTypeConfiguration<Student_Course>
    {
        public void Configure(EntityTypeBuilder<Student_Course> builder)
        {
            builder.HasKey(x => x.StudentId);

            builder.Property(x => x.StudentId).UseIdentityColumn(10,10);

            builder.Property(x => x.CourseId).IsRequired();



            builder.Property(x => x.Grade).IsRequired()
                   .HasDefaultValue(10)
                   .HasColumnName("Student Grade");

            builder.HasIndex(x => x.Grade).IsUnique();
        }
    }
}
