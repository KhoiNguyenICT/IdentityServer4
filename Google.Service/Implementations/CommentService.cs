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

        public async Task<QueryResult<CommentDto>> Query(Guid commentIn, int page, int pageSize)
        {
            var query = _context.Comments.Where(x => x.ChannelId == commentIn || x.VideoId == commentIn);
            var totalRow = query.Count();
            var result = await query.OrderByDescending(x => x.CreatedDate).Skip((page - 1) * pageSize).Take(pageSize).ToListAsync();
            var data = result.To<List<CommentDto>>();
            var paginationSet = new QueryResult<CommentDto>()
            {
                Results = data,
                CurrentPage = page,
                RowCount = totalRow,
                PageSize = pageSize
            };
            return paginationSet;
        }
    }
}