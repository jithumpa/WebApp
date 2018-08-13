using System.Collections.Generic;
using WebApp.Domain.Entities;

namespace WebApp.Service.Entity
{
    public interface IEntityService<T> where T : BaseEntity
    {
        T GetById(long id);

        void Create(T entity);

        IList<T> GetAllAsList();

        void DeleteById(long id);

        void Update(T entity);      
    }
}
