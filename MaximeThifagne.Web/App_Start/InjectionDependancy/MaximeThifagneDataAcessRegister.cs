using Autofac;
using MaximeThifagne.DataAccess.Command.Implementation;
using MaximeThifagne.DataAccess.Command.Interface;
using MaximeThifagne.DataAccess.Query.Implementation;
using MaximeThifagne.DataAccess.Query.Interface;

namespace MaximeThifagne.Unity
{
    public static class MaximeThifagneDataAcessRegister
    {
        public static void Register(ContainerBuilder builder)
        {
            builder.RegisterType<ContactCommand>().As<IContactCommand>();
            builder.RegisterType<UserCommand>().As<IUserCommand>();
            builder.RegisterType<ArticleCommand>().As<IArticleCommand>();
            builder.RegisterType<ArticleQuery>().As<IArticleQuery>();
            builder.RegisterType<CommentCommand>().As<ICommentCommand>();
        }
    }
}
