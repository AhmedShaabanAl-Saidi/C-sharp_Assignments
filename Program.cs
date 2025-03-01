using Assignment1_C_.Models;
using Microsoft.EntityFrameworkCore;

namespace Assignment1_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region CRUD
            //using ITIDbContext context = new ITIDbContext();

            //#region Insert
            //Student student1 = new Student() { FirstName = "Ahmed" , LastName = "Alsaidy" , Address = "Mounfia" , Age = 25 , DepartmentId = 1};
            //Student student2 = new Student() { FirstName = "Mohamed", Address = "Cairo", Age = 22, DepartmentId = 2 };

            //context.Students.Add(student1);
            //context.Students.Add(student2);

            //context.SaveChanges();
            //#endregion

            #region Read
            //var student = context.Students.Where(x => x.StudentId == 10).AsNoTracking().FirstOrDefault();   

            //if (student != null)
            //    Console.WriteLine(student.FirstName);
            //else
            //    Console.WriteLine("Student Not Found");
            #endregion

            #region Update
            //var student = context.Students.Where(x => x.StudentId == 10).FirstOrDefault();

            //if (student != null)
            //{
            //    student.FirstName = "Ali";

            //    context.SaveChanges();

            //    Console.WriteLine(student.FirstName);
            //}
            //else
            //    Console.WriteLine("Student Not Found");
            #endregion

            #region Delete
            //var student = context.Students.Where(x => x.StudentId == 10).FirstOrDefault();

            //if (student != null)
            //{
            //    context.Students.Remove(student);

            //    context.SaveChanges();

            //    Console.WriteLine("Student Deleted successfully...");
            //}
            //else
            //    Console.WriteLine("Student Not Found");
            #endregion
            #endregion
        }
    }
}
