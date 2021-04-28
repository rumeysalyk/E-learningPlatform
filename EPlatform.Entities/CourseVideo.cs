using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EPlatform.Entities
{
    public class CourseVideo
    {
        
        public int Id { get; set; }
        [Required]
        public string VideoTitle { get; set; }
        [Required]
        public string VideoUrl { get; set; }
        public string VideoDescription { get; set; }
        public DateTime VideoDateTime { get; set; }
        public string VideoPublicId { get; set; }



        //************

        [Required]
        public int CourseId { get; set; }
        public Course Course { get; set; }
        
    }
}
