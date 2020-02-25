using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceCRUD.Models
{
   public interface IDataRepository<TEntity>
    {
        IEnumerable<TEntity> GetAll();
        TEntity Get(int id);
        void Add(TEntity entity);
        void change(TEntity dbEntity, TEntity entity);
        void Delete(TEntity entity);
    }
}
