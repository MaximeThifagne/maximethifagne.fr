using MaximeThifagne.DTO.Enum;
using System;
using System.Collections.Generic;
using TypeLite;

namespace MaximeThifagne.DTO
{
    [TsClass]
    public class ArticleDto
    {
        public int ArticleId { get; set; }

        public string ArticleTitle { get; set; }

        public string ArticleBody { get; set; }

        public byte[] ArticlePhoto { get; set; }

        public string ArticleSource { get; set; }

        public string ArticleSourceLink { get; set; }

        public DateTime ArticleCreationDate { get; set; }

        public UserDto User { get; set; }

        public CategoryEnum Category { get; set; }

        public List<SubArticleDto> SubArticles { get; set; }

        public List<CommentDto> Comments { get; set; }
    }
}
