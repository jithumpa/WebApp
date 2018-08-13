using System.Collections.Generic;
using WebApp.Domain.Entities;

namespace WebApp.DAL
{
    public interface IGenericRepository<T> where T :  BaseEntity
    {
        T GetById(long id);       

        void DeleteById(long id);

        IEnumerable<T> GetAll();

        IList<T> GetAllAsList();      

        void Insert(T entity);       

        void Update(T entity);     

        void Archive(long id);
    }
}
