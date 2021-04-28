using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EPlatform.Entities
{
    public class Post
    {
        
        public int Id { get; set; }
        public string PostText { get; set; }
        public DateTime PostDateTime { get; set; }


        //*************
        
        [Required]
        public string UserId { get; set; }
        public User User { get; set; }

        [Required]
        public int BranchId { get; set; }
        public Branch Branch { get; set; }

        public List<Image> Images { get; set; }
        public List<Video> Videos { get; set; }
        
    }
}
