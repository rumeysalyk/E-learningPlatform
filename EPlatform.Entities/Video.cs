using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EPlatform.Entities
{
    public class Video
    {
        
        public int Id { get; set; }
        
        public string VideoUrl { get; set; }
        public string VideoDescription { get; set; }
        public DateTime VideoDateTime { get; set; }
        public string VideoPublicId { get; set; }

        [Required]
        public int PostId { get; set; } //foreign key
        public Post Post { get; set; }
        
    }
}
