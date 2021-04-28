using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EPlatform.Entities
{
    public class Image
    {
        
        public int Id { get; set; }
        public string ImageUrl { get; set; }
        public string ImageDescription { get; set; }
        public string ImagePublicId { get; set; }


        //******************

        [Required]
        public int PostId { get; set; }
        public Post Post { get; set; }
        
    }
}
