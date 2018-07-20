using AutoMapper;
using Google.Common.Interfaces;
using Google.Model;
using Google.Service.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Google.Service.Implementations
{
    public class BaseService<TEntity, TDto> : IService<TDto> where TEntity : class, IEntity, new()
    {
        protected AppDbContext _context;

        public BaseService(AppDbContext context)
        {
            _context = context;
        }

        public virtual async Task Add(TDto entity)
        {
            var mappedEntity = Mapper.Map<TEntity>(entity);
            _context.Set<TEntity>().Add(mappedEntity);
            await _context.SaveChangesAsync();
        }

        public virtual async Task<TDto> Get(Guid id)
        {
            var entity = await _context.Set<TEntity>()
                .AsNoTracking()
                .SingleOrDefaultAsync(x => x.Id == id);
            var mappedEntity = Mapper.Map<TDto>(entity);
            return mappedEntity;
        }

        public virtual async Task<List<TDto>> GetAll()
        {
            var entities = await _context.Set<TEntity>().AsNoTracking().ToListAsync();
            var mappedEntities = Mapper.Map<List<TDto>>(entities);
            return mappedEntities;
        }

        public virtual async Task Update(TDto entity)
        {
            var mappedEntity = Mapper.Map<TEntity>(entity);
            _context.Entry(mappedEntity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public virtual async Task Remove(Guid id)
        {
            var entity = await _context.Set<TEntity>().FindAsync(id);
            var mappedEntity = Mapper.Map<TEntity>(entity);
            _context.Set<TEntity>().Remove(mappedEntity);
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}