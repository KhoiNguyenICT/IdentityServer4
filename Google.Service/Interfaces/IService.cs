using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Google.Common.Cores;
using Google.Common.Enums;

namespace Google.Service.Interfaces
{
    public interface IService<TDto>
    {
        Task AddAsync(TDto entity);

        Task<TDto> GetAsync(Guid id);

        Task<List<TDto>> GetAllAsync();

        Task UpdateAsync(TDto entity);

        Task RemoveAsync(Guid id);
    }
}