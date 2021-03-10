using GS.DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GS.REPO
{
    public interface IRepository<T>where T: BaseEntity
    {
        IEnumerable<T> GetAllIEnumerable();
        IQueryable<T> GetAllIQueryable ();
        List<T> GetAll();
        T Get(int id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        Task<T> GetAsync(int id);
        Task InsertAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
    }
}