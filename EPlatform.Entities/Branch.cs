using System;
using System.Collections.Generic;
using System.Text;

namespace EPlatform.Entities
{
    public class Branch
    {
        
        public int Id { get; set; }
        public string BranchName { get; set; }


        //***********
        public List<Post> Posts { get; set; }
        public List<Topic> Topics { get; set; }
        public List<Course> Courses { get; set; }
        

    }
}
