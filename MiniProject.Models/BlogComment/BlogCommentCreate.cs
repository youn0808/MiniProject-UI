using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject.Models.BlogComment
{
    public class BlogCommentCreate
    {
        public int BlogCommentId { get; set; }
        public int? ParentBlogCommentId { get; set; }
        public int BlogId { get; set; }

        [Required(ErrorMessage = "Content is required")]
        [MinLength(10, ErrorMessage = "It should be over 10 characters")]
        [MaxLength(300, ErrorMessage = "It should not be over 300 characters")]
        public string Content { get; set; }

    }
}
