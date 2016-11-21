using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AllInOne_blog.Models
{
    public class Post
    {
        public Post()
        {
            this.Date = DateTime.Now;
        }
        [Key]
        public int ID { get; set; }


        [Required]
        public string Body { get; set; }

        [Required]
        public DateTime Date { get; set; }

        
        public ApplicationUser Author { get; set; }


    }
}