using StudentFollow.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace StudentFollow.Context
{
    public class StudentDbContext:DbContext
    {
        public StudentDbContext():base("StudentDBConnectionString")
        {

        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Classroom> Classrooms { get; set; }
    }
}