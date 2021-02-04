using CMS.Data.Core;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

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
            new Student{FirstMidName="Carson",LastName="Alexander",RegistrationDate=DateTime.Parse("2014-09-01")},
            new Student{FirstMidName="Meredith",LastName="Alonso",RegistrationDate=DateTime.Parse("2018-09-01")},
            new Student{FirstMidName="Arturo",LastName="Anand",RegistrationDate=DateTime.Parse("2020-09-01")},
            new Student{FirstMidName="Gytis",LastName="Barzdukas",RegistrationDate=DateTime.Parse("2010-09-01")},
            new Student{FirstMidName="Yan",LastName="Li",RegistrationDate=DateTime.Parse("2012-09-01")},
            new Student{FirstMidName="Peggy",LastName="Justice",RegistrationDate=DateTime.Parse("1987-09-01")},
            new Student{FirstMidName="Laura",LastName="Norman",RegistrationDate=DateTime.Parse("21987-02-01")},
            new Student{FirstMidName="Nino",LastName="Olivetto",RegistrationDate=DateTime.Parse("2005-09-01")}
            };

            students.ForEach(s => context.Students.Add(s));
            context.SaveChanges();
        }
    }
}
