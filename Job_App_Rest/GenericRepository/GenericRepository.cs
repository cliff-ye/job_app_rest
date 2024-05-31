using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;
using Job_App_Rest.Data;
using Microsoft.EntityFrameworkCore;
using System.Security.Principal;

namespace Job_App_Rest.GenericRepository
{
    public abstract class GenericRepository<T> : ControllerBase, IGenericRepository<T> where T : class
    {
        private AppDbContext _dbContext;
        protected DbSet<T> _dbSet;
        public GenericRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<T>();
        }
        public async Task<T> Create(T entity)
        {
            _dbSet.Add(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<T> Delete(int id)
        {
            var data = await _dbSet.FindAsync(id);
          
            _dbSet.Remove(data);
            await _dbContext.SaveChangesAsync();
            return null;
        }

        public async Task<T> Get(int id)
        {
            var data = await _dbSet.FindAsync(id);
            
            return data;
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            var data = await _dbSet.ToListAsync();
            return data;
        }

        public async Task<T> Update(int id, T entity)
        {
            var existingEntity = await _dbSet.FindAsync(id);
            
            _dbContext.Entry(existingEntity).State = EntityState.Modified;
            try
            {
                await _dbContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }

            return null;
        }
    }
}
