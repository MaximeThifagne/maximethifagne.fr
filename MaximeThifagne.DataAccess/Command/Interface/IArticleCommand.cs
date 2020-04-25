using MaximeThifagne.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximeThifagne.DataAccess.Command.Interface
{
    public interface IArticleCommand
    {
        ArticleDto AddArticle(ArticleDto article);

        bool DeleteArticle(int articleId);
    }
}
