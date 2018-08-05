using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Google.Service.Dtos;
using Google.Service.Dtos.Category;

namespace Google.Service.Interfaces
{
    public interface ICategoryService: IService<CategoryDto>
    {
        Task UpdateInfoAsync(CategoryDto dto);

        Task UpdateParentAsync(CategoryUpdateParentDto dto);

        Task<IEnumerable<CategoryDto>> GetTreeCategoryAsync();
    }
}