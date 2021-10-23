using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Domain.Base
{
    public interface IGenericRepository<Tkey,TEntity> 
        where Tkey : struct
        where TEntity : class, new()
    {
        void Add(TEntity entity);
        void Edit(TEntity entity);
        void Delete(Tkey id);
        TEntity Find(Tkey id);
        IQueryable<TEntity> GetAll();
    }
}
