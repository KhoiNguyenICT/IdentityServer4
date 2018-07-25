using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Google.Common.Cores;
using Google.Common.Enums;

namespace Google.Service.Interfaces
{
    public interface IService<TDto> : IDisposable
    {
        Task Add(TDto entity);

        Task<TDto> Get(Guid id);

        Task<List<TDto>> GetAll();

        Task Update(TDto entity);

        Task Remove(Guid id);
    }
}