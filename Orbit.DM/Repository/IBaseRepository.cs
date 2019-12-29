//####################################################################
// Project:         OrbitTest
// Author:          Jonathan Dávila A.
// DATA:            29/12/2019
// Comment:         interfaz for repository
//####################################################################
namespace Orbit.DM.Repository
{
    using Microsoft.EntityFrameworkCore.Query;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Text;

    public interface IBaseRepository<TEntity>
    {
        IQueryable<TEntity> GetAll();
        IQueryable<TEntity> GetAllBy(Expression<Func<TEntity, bool>> predicate);
        IQueryable<TEntity> QueryObjectGraph(Expression<Func<TEntity, bool>> filter, string children);
        List<TEntity> Get(Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>> include = null);
        TEntity FindById(object id);
        void Create(TEntity entity);
        void Delete(TEntity entity);
        void Update(TEntity entity);
    }
}
