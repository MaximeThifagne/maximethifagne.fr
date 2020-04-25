using MaximeThifagne.Entity.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MaximeThifagne.Entity.Entities
{
    [Table("mt.ARTICLE")]
    public class ArticleEntity
    {
        [Key]
        [Column(name:"ARTICLE_ID")]
        public int ArticleId { get; set; }

        [Column(name: "ARTICLE_TITLE")]
        public string ArticleTitle { get; set; }

        [Column(name: "ARTICLE_BODY")]
        public string ArticleBody { get; set; }

        [Column(name: "ARTICLE_PHOTO")]
        public byte[] ArticlePhoto { get; set; }

        [Column(name: "ARTICLE_SOURCE")]
        public string ArticleSource { get; set; }

        [Column(name: "ARTICLE_SOURCE_LINK")]
        public string ArticleSourceLink { get; set; }

        [Column(name:"ARTICLE_CREATION_DATE")]
        public DateTime ArticleCreationDate { get; set; }

        [Column(name: "ARTICLE_USER_ID")]
        [ForeignKey("User")]
        public int ArticleUserdId { get; set; }

        public CategoryEnum Category { get; set; }

        public UserEntity User { get; set; }

        public List<SubArticleEntity> SubArticles { get; set; }

        public List<CommentEntity> Comments { get; set; }
    }
}
