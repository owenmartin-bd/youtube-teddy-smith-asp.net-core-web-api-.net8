using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core_Web_API_.NET_8.Dtos.Comment
{
    public class CreateCommentDto
    {
        [Required]
        [MinLength(5, ErrorMessage = "Title must be at least 5 characters long")]
        [MaxLength(280, ErrorMessage = "Title must be at most 280 characters long")]
        public string Title { get; set; } = string.Empty;
        [Required]
        [MinLength(5, ErrorMessage = "Content must be at least 5 characters long")]
        [MaxLength(280, ErrorMessage = "Content must be at most 280 characters long")]
        public string Content { get; set; } = string.Empty;
    }
}