using System.Collections.Generic;
using WebApp.Domain.Entities;

namespace WebApp.DAL
{
    public abstract class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        public IEnumerable<T> GetAll()
        {
            return null;
        }

        public T GetById(long id)
        {
            return null;
        }
        
        public void DeleteById(long id)
        {            
        }

        public IList<T> GetAllAsList()
        {
           return null;
        }      

        public void Insert(T entity)
        {            
        }       

        public void Update(T entity)
        {            
        }
       
        public void Archive(long id)
        {            
        }
    }
}
