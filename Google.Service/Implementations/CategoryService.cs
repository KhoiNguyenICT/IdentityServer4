using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Google.Common.Enums;
using Google.Model;
using Google.Model.Entities;
using Google.Service.Dtos.Category;
using Google.Service.Interfaces;

namespace Google.Service.Implementations
{
    public class CategoryService : BaseService<Category, CategoryDto>, ICategoryService
    {
        public CategoryService(AppDbContext context) : base(context)
        {
        }

        public async Task UpdateInfoAsync(CategoryDto dto)
        {
            var categoryDto = await GetAsync(dto.Id);
            categoryDto.Name = dto.Name;
            await UpdateAsync(categoryDto);
        }

        public async Task UpdateParentAsync(CategoryUpdateParentDto dto)
        {
            var categoryDto = await GetAsync(dto.Id);
            categoryDto.ParentId = dto.ParentId;
            await UpdateAsync(categoryDto);
        }

        public async Task<IEnumerable<CategoryDto>> GetTreeCategoryAsync()
        {
            var categories = await GetAllAsync();
            var data = BuildTreeTheme(null, categories);
            return data;
        }

        private IEnumerable<CategoryDto> BuildTreeTheme(Guid? themeParentId, IEnumerable<CategoryDto> source)
        {
            var categoryDtos = source as CategoryDto[] ?? source.ToArray();
            return categoryDtos.Where(item => (themeParentId == null && (item.ParentId == Guid.Empty || item.ParentId == null)) || (item.ParentId != null && item.ParentId == themeParentId)).Select(theme => new CategoryDto()
            {
                Id = theme.Id,
                Name = theme.Name,
                Children = BuildTreeTheme(theme.Id, categoryDtos).ToList(),
            });
        }
    }
}