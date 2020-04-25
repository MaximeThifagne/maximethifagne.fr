using MaximeThifagne.DTO;

namespace MaximeThifagne.DataAccess.Command.Interface
{
    public interface ICommentCommand
    {
        CommentDto AddComment(CommentDto comment, int articleId);

        void DeleteComment(int commentId);
    }
}
