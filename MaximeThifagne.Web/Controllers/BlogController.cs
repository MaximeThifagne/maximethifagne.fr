using MaximeThifagne.DataAccess.Command.Interface;
using MaximeThifagne.DataAccess.Query.Interface;
using MaximeThifagne.DTO;
using MaximeThifagne.DTO.Enum;
using MaximeThifagne.Models;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MaximeThifagne.Controllers
{
    public class BlogController : Controller
    {
        private IArticleQuery ArticleQuery;
        private IArticleCommand ArticleCommand;
        private ICommentCommand CommentCommand;
        public BlogController(IArticleQuery articleQuery, IArticleCommand articleCommand, ICommentCommand commentCommand)
        {
            ArticleQuery = articleQuery;
            ArticleCommand = articleCommand;
            CommentCommand = commentCommand;
        }

        public BlogController()
        {

        }

        public ActionResult ListArticles(CategoryEnum? category)
        {
            List<ArticleViewModel> articlesVm = new List<ArticleViewModel>();
            IEnumerable<ArticleDto> articles = ArticleQuery.GetAllArticles(category);
            foreach (ArticleDto article in articles)
            {
                string articleBodyEllipsis = string.Empty;
                if (article.ArticleBody.Length >= 590)
                    articleBodyEllipsis = article.ArticleBody.Substring(0, 590) + " [...]";

                articlesVm.Add(new ArticleViewModel
                {
                    ArticleId = article.ArticleId,
                    ArticleTitle = article.ArticleTitle,
                    ArticleBody = string.IsNullOrWhiteSpace(articleBodyEllipsis) ? article.ArticleBody : articleBodyEllipsis,
                    Photo = article.ArticlePhoto,
                    ArticleSource = article.ArticleSource,
                    ArticleSourceLink = article.ArticleSourceLink,
                    ArticleCreationDate = article.ArticleCreationDate,
                    ArticleUserFullName = article.User.UserFirstName + article.User.UserLastName,
                    Category = article.Category
                });
            }
            return View(articlesVm);
        }

        public ActionResult Article(int articleId)
        {
            ArticleDto articleDto = ArticleQuery.GetArticle(articleId);

            ArticleViewModel article = new ArticleViewModel
            {
                ArticleId = articleDto.ArticleId,
                ArticleTitle = articleDto.ArticleTitle,
                ArticleBody = articleDto.ArticleBody,
                Photo = articleDto.ArticlePhoto,
                ArticleSource = articleDto.ArticleSource,
                ArticleSourceLink = articleDto.ArticleSourceLink,
                ArticleCreationDate = articleDto.ArticleCreationDate,
                ArticleUserFullName = articleDto.User.UserFirstName + articleDto.User.UserLastName,
                SubArticles = articleDto.SubArticles,
                Comments = articleDto.Comments,
            };

            return View(article);
        }

        [Authorize]
        public ActionResult AddArticle()
        {
            return View();
        }

        [Authorize]
        [HttpPost]
        public ActionResult AddArticle(ArticleViewModel model)
        {
            var file = model.ArticlePhoto[0];

            byte[] fileContent = GetFileContent(file);

            ArticleDto article = new ArticleDto
            {
                ArticleTitle = model.ArticleTitle,
                ArticleBody = model.ArticleBody,
                ArticlePhoto = fileContent,
                ArticleSource = model.ArticleSource,
                ArticleSourceLink = model.ArticleSourceLink
                
            };

            ArticleCommand.AddArticle(article);

            return View(model);
        }

        public JsonResult AddComment(CommentDto comment, int articleId)
        {
            if (!ModelState.IsValid)
                return Json(new { success = false, issue = comment, errors = ModelState.Values.Where(i => i.Errors.Count > 0) });

            var result = CommentCommand.AddComment(comment, articleId);

            return Json(new { success = result });
        }

        public ActionResult DeleteArticle(int articleId)
        {
            ArticleCommand.DeleteArticle(articleId);

            return RedirectToAction("ListArticles");
        }

        public ActionResult DeleteComment(int commentId, int articleId)
        {
            CommentCommand.DeleteComment(commentId);

            return RedirectToAction("Article",new {articleId = articleId });
        }

        private static byte[] GetFileContent(HttpPostedFileBase file)
        {
            BinaryReader binaryReader = new BinaryReader(file.InputStream);
            return binaryReader.ReadBytes(file.ContentLength);
        }
    }
}