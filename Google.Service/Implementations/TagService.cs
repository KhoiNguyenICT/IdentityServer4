using Google.Model;
using Google.Model.Entities;
using Google.Service.Dtos;
using Google.Service.Dtos.Tag;
using Google.Service.Interfaces;

namespace Google.Service.Implementations
{
    public class TagService: BaseService<Tag, TagDto>, ITagService
    {
        public TagService(AppDbContext context) : base(context)
        {
        }
    }
}