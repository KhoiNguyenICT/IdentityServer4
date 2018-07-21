using Google.Model;
using Google.Model.Entities;
using Google.Service.Dtos;
using Google.Service.Dtos.Comment;
using Google.Service.Interfaces;

namespace Google.Service.Implementations
{
    public class CommentService : BaseService<Comment, CommentDto>, ICommentService
    {
        public CommentService(AppDbContext context) : base(context)
        {
        }
    }
}