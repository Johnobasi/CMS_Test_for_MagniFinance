using CMS.Data.Core;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CMS.Data
{
    public static class CMSseed
    {
        public static void Initialize(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.GetRequiredService<IServiceScopeFactory>()
                .CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
                context.Database.EnsureCreated();
                if (!context.Students.Any())
                {
                    context.Students.Add(new Student() { FirstMidName = "Carson", LastName = "Alexander", RegistrationDate = DateTime.Parse("2014-09-01"), Grades = Student.Grade.A });
                    context.Students.Add(new Student() { FirstMidName = "Meredith", LastName = "Alonso", RegistrationDate = DateTime.Parse("2018-09-01"), Grades = Student.Grade.C });
                    context.Students.Add(new Student() { FirstMidName = "Arturo", LastName = "Anand", RegistrationDate = DateTime.Parse("2020-09-01"), Grades = Student.Grade.F });
                    context.Students.Add(new Student() { FirstMidName = "Gytis", LastName = "Barzdukas", RegistrationDate = DateTime.Parse("2010-09-01"), Grades = Student.Grade.B });
                    context.Students.Add(new Student() { FirstMidName = "Yan", LastName = "Li", RegistrationDate = DateTime.Parse("2012-09-01"), Grades = Student.Grade.A });
                    context.Students.Add(new Student() {  FirstMidName = "Peggy", LastName = "Justice", RegistrationDate = DateTime.Parse("1987-09-01"), Grades = Student.Grade.D });
                    context.Students.Add(new Student() { FirstMidName = "Laura", LastName = "Norman", RegistrationDate = DateTime.Parse("1987-02-01"), Grades = Student.Grade.B });

                    context.SaveChanges();
                }


                if (!context.Courses.Any())
                {
                    context.Courses.Add(new Course() { ID = 1, Title = "Chemistry", Credits = 3 });
                    context.Courses.Add(new Course() { ID = 2, Title = "Microeconomics", Credits = 3 });
                    context.Courses.Add(new Course() { ID = 3, Title = "Macroeconomics", Credits = 3 });
                    context.Courses.Add(new Course() { ID = 4, Title = "Calculus", Credits = 4 });
                    context.Courses.Add(new Course() { ID = 5, Title = "Trigonometry", Credits = 4 });
                    context.Courses.Add(new Course() { ID = 6, Title = "Composition", Credits = 3 });
                    context.Courses.Add(new Course() { ID = 7, Title = "Literature", Credits = 4 });

                    context.SaveChanges();
                }

                if (!context.Subjects.Any())
                {
                    context.Subjects.Add(new Subject() { Name = "Chemistry" });
                    context.Subjects.Add(new Subject() { Name = "Microeconomics" });
                    context.Subjects.Add(new Subject() { Name = "Macroeconomics" });
                    context.Subjects.Add(new Subject() { Name = "Calculus" });
                    context.Subjects.Add(new Subject() { Name = "Trigonometry" });
                    context.Subjects.Add(new Subject() { Name = "Composition" });
                    context.Subjects.Add(new Subject() { Name = "Literature" });

                    context.SaveChanges();
                };

                if (!context.Teachers.Any())
                {
                    context.Teachers.Add(new Teacher() { FirstMidName = "John", LastName = "Edet" });
                    context.Teachers.Add(new Teacher() { FirstMidName = "Lucy", LastName = "Jimoh" });
                    context.Teachers.Add(new Teacher() { FirstMidName = "Jeffery", LastName = "Oke" });
                    context.Teachers.Add(new Teacher() { FirstMidName = "josh", LastName = "Martins" });
                    context.Teachers.Add(new Teacher() { FirstMidName = "John", LastName = "Okon" });
                    context.Teachers.Add(new Teacher() { FirstMidName = "John", LastName = "Goung" });
                    context.Teachers.Add(new Teacher() { FirstMidName = "John", LastName = "Inyang" });

                    context.SaveChanges();
                };

                if (!context.CMSSummaries.Any())
                {
                    context.CMSSummaries.Add(new CMSSummary() { StudentID = 1, CourseID = 1, TeacherID = 1, SubjectID = 1 });
                    context.CMSSummaries.Add(new CMSSummary() { StudentID = 2, CourseID = 2, TeacherID = 2, SubjectID = 2 });
                    context.CMSSummaries.Add(new CMSSummary() { StudentID = 3, CourseID = 3, TeacherID = 3, SubjectID = 3 });
                    context.CMSSummaries.Add(new CMSSummary() { StudentID = 4, CourseID = 4, TeacherID = 4, SubjectID = 4 });
                    context.CMSSummaries.Add(new CMSSummary() { StudentID = 5, CourseID = 5, TeacherID = 5, SubjectID = 5 });
                    context.CMSSummaries.Add(new CMSSummary() { StudentID = 6, CourseID = 6, TeacherID = 6, SubjectID = 6 });
                    context.CMSSummaries.Add(new CMSSummary() { StudentID = 7, CourseID = 7, TeacherID = 7, SubjectID = 7 });

                    context.SaveChanges();
                }
            }
            
           
        }
    }
}
