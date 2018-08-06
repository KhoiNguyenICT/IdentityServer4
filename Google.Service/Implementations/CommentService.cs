using Google.Common.Cores;
using Google.Common.Extensions;
using Google.Model;
using Google.Model.Entities;
using Google.Service.Dtos.Comment;
using Google.Service.Dtos.Video;
using Google.Service.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Google.Service.Implementations
{
    public class CommentService : BaseService<Comment, CommentDto>, ICommentService
    {
        public CommentService(AppDbContext context) : base(context)
        {
        }

        public Task<QueryResult<CommentDto>> Query(Guid commentIn, int page, int pageSize)
        {
            throw new NotImplementedException();
        }
    }
}