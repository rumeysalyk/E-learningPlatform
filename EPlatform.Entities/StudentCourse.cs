﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EPlatform.Entities
{
    public class StudentCourse
    {
        
        public string StudentId { get; set; }
        public User Student { get; set; }

        public int CourseId { get; set; }
        public Course Course { get; set; }
        

    }
}
