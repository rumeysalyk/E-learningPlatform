using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EPlatform.Entities
{
    public class User : IdentityUser
    {
        
        [Required]
        public string UserFirstName { get; set; }

        [Required]
        public string UserLastName { get; set; }


        //***
        public List<Post> Posts { get; set; }

        public List<StudentCourse> StudentCourses { get; set; }

        public List<Course> Courses { get; set; }
        
    }
}
