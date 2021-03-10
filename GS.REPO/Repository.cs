using GS.DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GS.REPO
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {

        private readonly AppDbContext context;
        public Repository(AppDbContext context)
        {
            this.context = context;
        }

        public void Delete(T entity)
        {
            context.Set<T>().Remove(entity);
            context.SaveChanges();
        }

        public async Task DeleteAsync(T entity)
        {
            context.Set<T>().Remove(entity);
            await context.SaveChangesAsync();
        }

        public T Get(int id)
        {
            return context.Set<T>().SingleOrDefault(s => s.Id == id);
        }

        public List<T> GetAll()
        {
            return context.Set<T>().ToList();
        }

        public IEnumerable<T> GetAllIEnumerable()
        {
            return context.Set<T>().AsEnumerable();
        }

        public IQueryable<T> GetAllIQueryable()
        {
            return context.Set<T>().AsQueryable();
        }

        public async Task<T> GetAsync(int id)
        {
            return await context.Set<T>().FindAsync(id);
        }

        public void Insert(T entity)
        {
            context.Set<T>().Add(entity);
            context.SaveChanges();
        }

        public async Task InsertAsync(T entity)
        {
            context.Set<T>().Add(entity);
            await context.SaveChangesAsync();
        }

        public void Update(T entity)
        {
            context.Set<T>().Update(entity);
            context.SaveChanges();
        }

        public async Task UpdateAsync(T entity)
        {
            context.Set<T>().Update(entity);
            await context.SaveChangesAsync();
        }
    }
}
