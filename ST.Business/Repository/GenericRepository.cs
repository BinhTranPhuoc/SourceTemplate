using Microsoft.EntityFrameworkCore;
using ST.Business.IRepository;
using ST.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ST.Business.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly SourceTemplateContext _context;

        public GenericRepository(SourceTemplateContext context)
        {
            _context = context;
        }

        public async Task<List<T>> GetAll()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public T Get(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public async Task<T> GetAsync(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async void Add(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
        }

        public void Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }

        public async void Delete(int id)
        {
            var entity = await _context.Set<T>().FindAsync(id);

            if (entity != null)
            {
                _context.Set<T>().Remove(entity);
            }
        }
    }
}
