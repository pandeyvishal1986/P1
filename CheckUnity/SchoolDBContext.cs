using CheckUnity.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SchoolDataLayer
{
    public class SchoolDBContext : DbContext
    {
        public SchoolDBContext() : base("name=SchoolDBConnectionString")
        {
            Database.SetInitializer<SchoolDBContext>(new SchoolDBInitializer());
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("dbo1");
            base.OnModelCreating(modelBuilder);
        }
    }

    public class SchoolDBInitializer : CreateDatabaseIfNotExists<SchoolDBContext>
    {
        protected override void Seed(SchoolDBContext context)
        {
            IList<Student> defaultStandards = new List<Student>();

            defaultStandards.Add(new Student() { StudentName = "Bill1", Weight = 100 });
            defaultStandards.Add(new Student() { StudentName = "Bill2", Weight = 100 });
            defaultStandards.Add(new Student() { StudentName = "Bill3", Weight = 100 });
            defaultStandards.Add(new Student() { StudentName = "Bill4", Weight = 78 });
            defaultStandards.Add(new Student() { StudentName = "Bill5", Weight = 90 });

            context.Students.AddRange(defaultStandards);
            base.Seed(context);
        }
    }
}