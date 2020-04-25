using AutoMapper;
using MaximeThifagne.DataAccess.Command.Interface;
using MaximeThifagne.DTO;
using MaximeThifagne.Entity;
using MaximeThifagne.Entity.Entities;
using System;
using System.Linq;

namespace MaximeThifagne.DataAccess.Command.Implementation
{
    public class ArticleCommand : IArticleCommand
    {
        private MaximeThifagneDbContext dbContext;
        private IMapper Mapper;

        public ArticleCommand(IMapper mapper)
        {
            dbContext = new MaximeThifagneDbContext();
            Mapper = mapper;
        }

        public ArticleDto AddArticle(ArticleDto article)
        {
            ArticleEntity articleToAdd = Mapper.Map<ArticleEntity>(article);
            articleToAdd.ArticleCreationDate = DateTime.Now;
            articleToAdd.ArticleUserdId = 1;

            dbContext.Articles.Add(articleToAdd);
            dbContext.SaveChanges();

            return article;
        }

        public bool DeleteArticle(int articleId)
        {
            dbContext.Articles.Remove(dbContext.Articles.Single(a => a.ArticleId == articleId));
            dbContext.SaveChanges();

            return true;
        }
    }
}
