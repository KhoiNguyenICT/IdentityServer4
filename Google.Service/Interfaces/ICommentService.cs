using System;
using System.Threading.Tasks;
using Google.Common.Cores;
using Google.Service.Dtos.Comment;
using Google.Service.Dtos.Video;

namespace Google.Service.Interfaces
{
    public interface ICommentService: IService<CommentDto>
    {
        Task<QueryResult<CommentDto>> Query(Guid commentIn, int page, int pageSize);
    }
}