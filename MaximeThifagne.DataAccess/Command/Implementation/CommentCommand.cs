using AutoMapper;
using MaximeThifagne.DataAccess.Command.Interface;
using MaximeThifagne.DTO;
using MaximeThifagne.Entity;
using MaximeThifagne.Entity.Entities;
using System;

namespace MaximeThifagne.DataAccess.Command.Implementation
{
    public class CommentCommand : ICommentCommand
    {
        private MaximeThifagneDbContext dbContext;
        private IMapper Mapper;

        public CommentCommand(IMapper mapper)
        {
            dbContext = new MaximeThifagneDbContext();
            Mapper = mapper;
        }

        public CommentDto AddComment(CommentDto comment, int articleId)
        {
            CommentEntity commentToAdd = Mapper.Map<CommentEntity>(comment);
            commentToAdd.ArticleId = articleId;
            commentToAdd.CommentCreationDate = DateTime.Now;

            dbContext.Comments.Add(commentToAdd);
            dbContext.SaveChanges();

            return comment;
        }

        public void DeleteComment(int commentId)
        {
            CommentEntity commentToDelete = dbContext.Comments.Find(commentId);

            if (commentToDelete != null)
                dbContext.Comments.Remove(commentToDelete);

            dbContext.SaveChanges();
        }
    }
}
