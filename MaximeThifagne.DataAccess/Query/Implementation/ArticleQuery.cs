using AutoMapper;
using MaximeThifagne.DataAccess.Query.Interface;
using MaximeThifagne.DTO;
using MaximeThifagne.DTO.Enum;
using MaximeThifagne.Entity;
using MaximeThifagne.Entity.Entities;
using System.Collections.Generic;
using System.Linq;

namespace MaximeThifagne.DataAccess.Query.Implementation
{
    public class ArticleQuery : IArticleQuery
    {
        private MaximeThifagneDbContext dbContext;
        private IMapper Mapper;

        public ArticleQuery(IMapper mapper)
        {
            dbContext = new MaximeThifagneDbContext();
            Mapper = mapper;
        }

        public IEnumerable<ArticleDto> GetAllArticles(CategoryEnum? cateogry)
        {
            List<ArticleEntity> articles = dbContext.Articles
                .Include("User").ToList();

            if(cateogry.HasValue)
            {
                IEnumerable<ArticleEntity> filteredArticles = articles.Where(a => a.Category == (Entity.Enum.CategoryEnum)cateogry.Value);
                return Mapper.Map<List<ArticleDto>>(filteredArticles);
            }

            return Mapper.Map<List<ArticleDto>>(articles);
        }

        public ArticleDto GetArticle(int articleId)
        {
            ArticleEntity article = dbContext.Articles
                .Include("User")
                .Include("SubArticles")
                .Include("Comments")
                .Where(a => a.ArticleId == articleId)
                .FirstOrDefault();

            return Mapper.Map<ArticleDto>(article);
        }

        public IEnumerable<ArticleDto> GetRecentArticles()
        {
            List<ArticleEntity> articles = dbContext.Articles.OrderByDescending(a => a.ArticleCreationDate).Take(5).ToList();

            return Mapper.Map<List<ArticleDto>>(articles);
        }
    }
}
