using CMS.Data.Core;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;

namespace CMS.Data
{
    public static class CMSseed
    {
        public static void Initialize(IServiceProvider provider)
        {
            var context = provider.GetRequiredService<ApplicationDbContext>();
            context.Database.EnsureCreated();

            var students = new List<Student>
            {
            new Student{FirstMidName="Carson",LastName="Alexander",RegistrationDate=DateTime.Parse("2014-09-01"), Grades=Student.Grade.A,},
            new Student{FirstMidName="Meredith",LastName="Alonso",  RegistrationDate=DateTime.Parse("2018-09-01"), Grades=Student.Grade.C,},
            new Student{FirstMidName="Arturo",LastName="Anand",RegistrationDate=DateTime.Parse("2020-09-01"), Grades=Student.Grade.F,},
            new Student{FirstMidName="Gytis",LastName="Barzdukas",RegistrationDate=DateTime.Parse("2010-09-01"), Grades=Student.Grade.B,},
            new Student{FirstMidName="Yan",LastName="Li",RegistrationDate=DateTime.Parse("2012-09-01"), Grades=Student.Grade.A,},
            new Student{FirstMidName="Peggy",LastName="Justice",RegistrationDate=DateTime.Parse("1987-09-01"), Grades=Student.Grade.D,},
            new Student{FirstMidName="Laura",LastName="Norman",RegistrationDate=DateTime.Parse("21987-02-01"), Grades=Student.Grade.B,},
            new Student{FirstMidName="Nino",LastName="Olivetto",RegistrationDate=DateTime.Parse("2005-09-01"), Grades=Student.Grade.D,}
            };

            students.ForEach(s => context.Students.Add(s));
            context.SaveChanges();

            var courses = new List<Course>
            {
            new Course{ID=1050,Title="Chemistry",Credits=3,},
            new Course{ID=4022,Title="Microeconomics",Credits=3,},
            new Course{ID=4041,Title="Macroeconomics",Credits=3,},
            new Course{ID=1045,Title="Calculus",Credits=4,},
            new Course{ID=3141,Title="Trigonometry",Credits=4,},
            new Course{ID=2021,Title="Composition",Credits=3,},
            new Course{ID=2042,Title="Literature",Credits=4,}
            };

            courses.ForEach(s => context.Courses.Add(s));
            context.SaveChanges();

            var subjects = new List<Subject>
            {
            new Subject{Id=1,Name="Chemistry"},
            new Subject{Id=2,Name="Microeconomics"},
            new Subject{Id=3,Name="Macroeconomics"},
            new Subject{Id=4,Name="Calculus"},
            new Subject{Id=5,Name="Trigonometry"},
            new Subject{Id=6,Name="Composition"},
            new Subject{Id=7,Name="Literature"}
            };

            courses.ForEach(s => context.Courses.Add(s));
            context.SaveChanges();

            var techers = new List<Teacher>
            {
            new Teacher{ID=1, FirstMidName="John", LastName="Edet",},
            new Teacher{ID=2, FirstMidName="Lucy", LastName="Jimoh",},
            new Teacher{ID=3, FirstMidName="Jeffery", LastName="Oke",},
            new Teacher{ID=4, FirstMidName="josh", LastName="Martins",},
            new Teacher{ID=5, FirstMidName="John", LastName="Okon",},
            new Teacher{ID=6, FirstMidName="John", LastName="Goung",},
            new Teacher{ID=7, FirstMidName="John", LastName="Inyang",}
            };

            courses.ForEach(s => context.Courses.Add(s));
            context.SaveChanges();

            var summary = new List<CMSSummary>
            {
            new CMSSummary{StudentID=1,CourseID=1, TeacherID=1,SubjectID=1},
            new CMSSummary{StudentID=2,CourseID=2, TeacherID=2,SubjectID=2},
            new CMSSummary{StudentID=3,CourseID=3, TeacherID=3,SubjectID=3},
            new CMSSummary{StudentID=4,CourseID=4, TeacherID=4,SubjectID=4},
            new CMSSummary{StudentID=5,CourseID=5, TeacherID=5,SubjectID=5},
            new CMSSummary{StudentID=6,CourseID=6, TeacherID=6,SubjectID=6},
            new CMSSummary{StudentID=7,CourseID=7, TeacherID=7,SubjectID=7},
            };

            courses.ForEach(s => context.Courses.Add(s));
            context.SaveChanges();
        }
    }
}
