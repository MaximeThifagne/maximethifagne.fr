using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MaximeThifagne.DTO
{
    public class CommentDto
    {
        public int CommentId { get; set; }

        [DisplayName("Nom")]
        [Required]
        public string CommentatorName { get; set; }

        [DisplayName("Email")]
        [Required]
        public string CommentatorEmail { get; set; }

        [DisplayName("Site internet")]
        public string CommentatorWebSite { get; set; }

        [DisplayName("Message")]
        [Required]
        public string CommentMessage { get; set; }

        public DateTime CommentDate { get; set; }

        public ArticleDto Article { get; set; }
    }
}
