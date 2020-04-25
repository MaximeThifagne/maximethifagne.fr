using MaximeThifagne.DTO;
using MaximeThifagne.DTO.Enum;
using System.Collections.Generic;

namespace MaximeThifagne.DataAccess.Query.Interface
{
    public interface IArticleQuery
    {
        ArticleDto GetArticle(int articleId);
        IEnumerable<ArticleDto> GetAllArticles(CategoryEnum? category);

        IEnumerable<ArticleDto> GetRecentArticles();
    }
}
