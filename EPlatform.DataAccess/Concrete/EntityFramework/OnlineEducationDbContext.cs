using EPlatform.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EPlatform.DataAccess.Concrete.EntityFramework
{
    public class OnlineEducationDbContext : IdentityDbContext<User>
    {
        public OnlineEducationDbContext(DbContextOptions<OnlineEducationDbContext> options) : base(options)
        {
        }

        
        public DbSet<Course> Courses { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Video> Videos { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<CourseVideo> CourseVideos { get; set; }

        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            
            // Many-to-Many
            builder
                .Entity<StudentCourse>()
                .HasKey(sc => new { sc.StudentId, sc.CourseId });

            builder
                .Entity<StudentCourse>()
                .HasOne(sc => sc.Student)
                .WithMany(s => s.StudentCourses)
                .HasForeignKey(sc => sc.StudentId);

            builder
               .Entity<StudentCourse>()
               .HasOne(sc => sc.Course)
               .WithMany(c => c.StudentCourses)
               .HasForeignKey(sc => sc.CourseId);

            //One-to-Many
            builder
               .Entity<Course>()
               .HasOne(c => c.Teacher)
               .WithMany(t => t.Courses)
               .HasForeignKey(c => c.TeacherId )
               .OnDelete(DeleteBehavior.Restrict); //bu ne için??

            builder
               .Entity<Course>()
               .HasOne(c => c.Topic)
               .WithMany(t => t.Courses)
               .HasForeignKey(c => c.TopicId)
               .OnDelete(DeleteBehavior.Restrict);

            builder
               .Entity<Course>()
               .HasOne(c => c.Branch)
               .WithMany(t => t.Courses)
               .HasForeignKey(c => c.BranchId)
               .OnDelete(DeleteBehavior.Restrict);

            builder
               .Entity<Post>()
               .HasOne(c => c.User)
               .WithMany(t => t.Posts)
               .HasForeignKey(c => c.UserId)
               .OnDelete(DeleteBehavior.Restrict);



            builder
               .Entity<CourseVideo>()
               .HasOne(c => c.Course)
               .WithMany(t => t.CourseVideos)
               .HasForeignKey(c => c.CourseId)
               .OnDelete(DeleteBehavior.Restrict);

            builder
               .Entity<Image>()
               .HasOne(c => c.Post)
               .WithMany(t => t.Images)
               .HasForeignKey(c => c.PostId)
               .OnDelete(DeleteBehavior.Restrict);

            builder
               .Entity<Post>()
               .HasOne(c => c.Branch)
               .WithMany(t => t.Posts)
               .HasForeignKey(c => c.BranchId)
               .OnDelete(DeleteBehavior.Restrict);

            builder
               .Entity<Topic>()
               .HasOne(c => c.Branch)
               .WithMany(t => t.Topics)
               .HasForeignKey(c => c.BranchId)
               .OnDelete(DeleteBehavior.Restrict);

            builder
               .Entity<Video>()
               .HasOne(c => c.Post)
               .WithMany(t => t.Videos)
               .HasForeignKey(c => c.PostId)
               .OnDelete(DeleteBehavior.Restrict);


            

        }
    }
}
