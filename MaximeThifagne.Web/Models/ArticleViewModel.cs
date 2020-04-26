using MaximeThifagne.DTO;
using MaximeThifagne.DTO.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace MaximeThifagne.Models
{
    public class ArticleViewModel
    {
        public ArticleViewModel()
        {
            ArticlePhoto = new List<HttpPostedFileBase>();
        }

        public int ArticleId { get; set; }

        [Required]
        [Display(Name = "Titre")]
        public string ArticleTitle { get; set; }

        [Required]
        [Display(Name = "Contenu")]
        public string ArticleBody { get; set; }

        [Display(Name = "Photo")]
        public List<HttpPostedFileBase> ArticlePhoto { get; set; }

        [Display(Name = "Photo")]
        public byte[] Photo { get; set; }

        public CategoryEnum Category { get; set; }

        public List<SubArticleDto> SubArticles { get; set; }

        public CommentDto Comment { get; set; }

        public List<CommentDto> Comments { get; set; }

        [Required]
        [Display(Name = "Source")]
        public string ArticleSource { get; set; }

        [Required]
        [Display(Name = "Lien de la source")]
        public string ArticleSourceLink { get; set; }

        public DateTime ArticleCreationDate { get; set; }

        public string ArticleUserFullName { get; set; }

        public HtmlString GetArticlePreview()
        {
            if (this.ArticleBody.Length > 250)
                return new HtmlString(this.ArticleBody.Substring(0, 250) + " [... Lire plus]");
            else
                return new HtmlString(this.ArticleBody);
        }
    }
}