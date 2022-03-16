using System;
using System.Collections.Generic;
using System.Linq;

namespace Infraestructure.Repository.Base
{
    public interface IBaseRepository<TEntity>
    {
        IQueryable<TEntity> GetAll();
        TEntity FindById(object id);
        TEntity Create(TEntity entity, bool autoSave = true);
        TEntity Update(TEntity entity, bool autoSave = true);
        void Delete(TEntity entity, bool autoSave = true);
        void SaveChanges();



    }

}
