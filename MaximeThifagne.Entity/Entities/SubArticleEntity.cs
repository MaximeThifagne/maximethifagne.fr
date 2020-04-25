using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximeThifagne.Entity.Entities
{
    [Table("mt.SUB_ARTICLE")]
    public class SubArticleEntity
    {
        [Key]
        [Column(name: "SUB_ARTICLE_ID")]
        public int SubArticleId { get; set; }

        [Column(name: "SUB_ARTICLE_TITLE")]
        public string SubArticleTitle { get; set; }

        [Column(name: "SUB_ARTICLE_BODY")]
        public string SubArticleBody { get; set; }

        [Column(name: "SUB_ARTICLE_PHOTO")]
        public byte[] SubArticlePhoto { get; set; }

        [Column(name: "ARTICLE_ID")]
        [ForeignKey("Article")]
        public int ArticleId { get; set; }

        public ArticleEntity Article { get; set; }
    }
}
