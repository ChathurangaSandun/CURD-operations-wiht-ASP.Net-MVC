using System.Collections.Generic;
using Testasp.Models;

namespace testingaspmvc.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<testingaspmvc.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(testingaspmvc.Models.ApplicationDbContext context)
        {
            //var students = new List<Student>
            //{
            //new Student{FirstMidName="Carson",LastName="Alexander",EnrollmentDate=DateTime.Parse("2005-09-01")},
            //new Student{FirstMidName="Meredith",LastName="Alonso",EnrollmentDate=DateTime.Parse("2002-09-01")},
            //new Student{FirstMidName="Arturo",LastName="Anand",EnrollmentDate=DateTime.Parse("2003-09-01")},
            //new Student{FirstMidName="Gytis",LastName="Barzdukas",EnrollmentDate=DateTime.Parse("2002-09-01")},
            //new Student{FirstMidName="Yan",LastName="Li",EnrollmentDate=DateTime.Parse("2002-09-01")},
            //new Student{FirstMidName="Peggy",LastName="Justice",EnrollmentDate=DateTime.Parse("2001-09-01")},
            //new Student{FirstMidName="Laura",LastName="Norman",EnrollmentDate=DateTime.Parse("2003-09-01")},
            //new Student{FirstMidName="Nino",LastName="Olivetto",EnrollmentDate=DateTime.Parse("2005-09-01")}
            //};

            //students.ForEach(s => context.Students.Add(s));
            //context.SaveChanges();
            //var courses = new List<Course>
            //{
            //new Course{CourseID=1,Title="Chemistry",Credits=3,},
            //new Course{CourseID=2,Title="Microeconomics",Credits=3,},
            //new Course{CourseID=3,Title="Macroeconomics",Credits=3,},
            //new Course{CourseID=4,Title="Calculus",Credits=4,},
            //new Course{CourseID=5,Title="Trigonometry",Credits=4,},
            //new Course{CourseID=6,Title="Composition",Credits=3,},
            //new Course{CourseID=7,Title="Literature",Credits=4,}
            //};
            //courses.ForEach(s => context.Courses.Add(s));
            //context.SaveChanges();
            //var enrollments = new List<Enrollment>
            //{
            //new Enrollment{StudentID=1,CourseID=1,Grade=Grade.A},
            //new Enrollment{StudentID=1,CourseID=1,Grade=Grade.C},
            //new Enrollment{StudentID=1,CourseID=1,Grade=Grade.B},
            //new Enrollment{StudentID=2,CourseID=2,Grade=Grade.B},
            //new Enrollment{StudentID=2,CourseID=2,Grade=Grade.F},
            //new Enrollment{StudentID=2,CourseID=3,Grade=Grade.F},
            //new Enrollment{StudentID=3,CourseID=5},
            //new Enrollment{StudentID=4,CourseID=8,},
            //new Enrollment{StudentID=4,CourseID=10,Grade=Grade.F},
            //new Enrollment{StudentID=5,CourseID=11,Grade=Grade.C},
            //new Enrollment{StudentID=6,CourseID=11},
            //new Enrollment{StudentID=7,CourseID=4,Grade=Grade.A},
            //};
            //enrollments.ForEach(s => context.Enrollments.Add(s));
            //context.SaveChanges();
        }
    }
}
