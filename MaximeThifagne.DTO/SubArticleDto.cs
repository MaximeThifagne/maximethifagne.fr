
namespace MaximeThifagne.DTO
{
    public class SubArticleDto
    {
        public int SubArticleId { get; set; }

        public string SubArticleTitle { get; set; }

        public string SubArticleBody { get; set; }

        public byte[] SubArticlePhoto { get; set; }

        public ArticleDto Article { get; set; }
    }
}
