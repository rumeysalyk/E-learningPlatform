using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EPlatform.Entities
{
    public class Course
    {
        
        public int Id { get; set; }
        [Required]
        public string CourseName { get; set; }
        public string CourseDescription { get; set; }


        //******
        [Required]
        public int BranchId { get; set; }
        public Branch Branch { get; set; }


        //It is for the teacher of that course
        [Required]
        public string TeacherId { get; set; }
        public User Teacher { get; set; }

        [Required]
        public int TopicId { get; set; }
        public Topic Topic { get; set; }

        public List<CourseVideo> CourseVideos { get; set; }
        public List<StudentCourse> StudentCourses { get; set; }
        
    }
}
