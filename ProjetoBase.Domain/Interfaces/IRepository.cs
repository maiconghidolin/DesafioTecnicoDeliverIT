using ProjetoBase.Domain.Entidades;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoBase.Domain.Interfaces
{
    public interface IRepository
    {
        void Add<TEntity>(TEntity entity) where TEntity : EntidadeBase;

        void Update<TEntity>(TEntity entity) where TEntity : EntidadeBase;

        void SaveChanges();

        int SaveOrUpdate<TEntity>(TEntity entity) where TEntity : EntidadeBase;

        void Delete<TEntity>(TEntity entity) where TEntity : EntidadeBase;

        void Delete(IEnumerable<object> entities);

        void Delete<TEntity>(int id) where TEntity : EntidadeBase;

        IQueryable<TEntity> Query<TEntity>() where TEntity : EntidadeBase;

        TEntity GetById<TEntity>(int id) where TEntity : EntidadeBase;

        IQueryable<TEntity> QueryAsNoTracking<TEntity>() where TEntity : EntidadeBase;

    }
}
