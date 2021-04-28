using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EPlatform.Entities
{
    public class Topic
    {
        
        public int Id { get; set; }
        public string TopicName { get; set; }

        //************

        public List<Course> Courses { get; set; }

        [Required]
        public int BranchId { get; set; }
        public Branch Branch { get; set; }

        
    }
}
