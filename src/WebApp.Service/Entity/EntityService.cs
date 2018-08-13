using System;
using System.Collections.Generic;
using WebApp.DAL;
using WebApp.Domain.Entities;

namespace WebApp.Service.Entity
{
    public abstract class EntityService<T> : IEntityService<T> 
        where T : BaseEntity
    {
        private readonly IGenericRepository<T> repository;

        protected EntityService(IGenericRepository<T> repository)
        {
            this.repository = repository;
        }      

        public T GetById(long id)
        {
            return this.repository.GetById(id);
        }
      
        public virtual void Create(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }

            this.repository.Insert(entity);
        }

        public IList<T> GetAllAsList()
        {
            return this.repository.GetAllAsList();
        }

        public void DeleteById(long id)
        {
            this.repository.DeleteById(id);
        }

        public void Update(T entity)
        {
            this.repository.Update(entity);
        }     
    }
}
