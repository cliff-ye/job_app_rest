using Microsoft.AspNetCore.Mvc;

namespace Job_App_Rest.GenericRepository
{
    public interface IGenericRepository<T> where T : class
    {
        public Task<IEnumerable<T>> GetAll();
        public Task<T> Get(int id);
        public Task<T> Create(T entity);
        public Task<T> Update(int id, T entity);
        public Task<T> Delete(int id);
    }
}
