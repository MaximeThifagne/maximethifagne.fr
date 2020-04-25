using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MaximeThifagne.Entity.Entities
{
    [Table("mt.COMMENT")]
    public class CommentEntity
    {
        [Key]
        [Column(name: "COMMENT_ID")]
        public int CommentId { get; set; }

        [Column(name: "COMMENT_COMMENTATOR_NAME")]
        public string CommentatorName { get; set; }

        [Column(name: "COMMENT_COMMENTATOR_EMAIL")]
        public string CommentatorEmail { get; set; }

        [Column(name: "COMMENT_COMMENTATOR_WEBSITE")]
        public string CommentatorWebSite { get; set; }

        [Column(name: "COMMENT_MESSAGE")]
        public string CommentMessage { get; set; }

        [Column(name: "COMMENT_CREATION_DATE")]
        public DateTime CommentCreationDate { get; set; }

        [Column(name: "ARTICLE_ID")]
        [ForeignKey("Article")]
        public int ArticleId { get; set; }

        public ArticleEntity Article { get; set; }
    }
}
