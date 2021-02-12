using Dominio;
using System;
using Microsoft.EntityFrameworkCore;




namespace Persistencia
{
    public class CoursesOnlineContext : DbContext
    {
        public CoursesOnlineContext(DbContextOptions options): base(options)
        {
            //base(options) it comes from his father (DbContext)

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder ){
           modelBuilder.Entity<Dominio.CourseInstructor>().Haskey( ci => new {ci.InstructorID, ci.CourseID} );
        }
        //wrapp our classes
        public DbSet<Comment> Comment {get;set;}
        public DbSet<Course> Course {get;set;}
        public DbSet<CourseInstructor> CourseInstructor {get;set;}
        public DbSet<Instructor> Instructor {get;set;}
        public DbSet<Price> Price {get;set;}
        //mapping finish

    }
}
