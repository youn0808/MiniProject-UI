using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject.Models.Blog
{
    public class BlogCreate
    {
        public int BlogId { get; set; }
        
        [Required(ErrorMessage = "Title is required")]
        [MinLength(10, ErrorMessage = "It should be over 10 characters")]
        [MaxLength(50, ErrorMessage = "Title should not be over 50 characters")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Content is required")]
        [MinLength(100, ErrorMessage = "It should be over 100 characters")]
        [MaxLength(3000, ErrorMessage = "It should not be over 3000 characters")]
        public string Content { get; set; }
        public int? PhotoId { get; set; }

    }
}
