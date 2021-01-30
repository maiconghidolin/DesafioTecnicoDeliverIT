using Microsoft.EntityFrameworkCore;
using ProjetoBase.Domain.Entidades;
using ProjetoBase.Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoBase.Infra.Repositories
{
    public class RepositorioGenerico : IRepository
    {
        private readonly DbContext _context;

        public RepositorioGenerico(DbContext context)
        {
            _context = context;
        }

        public void Add<TEntity>(TEntity entity) where TEntity : EntidadeBase
        {
            _context.Add<TEntity>(entity);
        }

        public void Update<TEntity>(TEntity entity) where TEntity : EntidadeBase
        {
            _context.Update<TEntity>(entity);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public int SaveOrUpdate<TEntity>(TEntity entity) where TEntity : EntidadeBase
        {
            if (entity.Id <= 0)
            {
                _context.Add<TEntity>(entity);
            }
            else
            {
                _context.Update<TEntity>(entity);
            }
            _context.SaveChanges();
            return entity.Id;
        }

        public void Delete<TEntity>(TEntity entity) where TEntity : EntidadeBase
        {
            _context.Remove<TEntity>(entity);
            _context.SaveChanges();
        }

        public void Delete(IEnumerable<object> entities)
        {
            _context.RemoveRange(entities);
            _context.SaveChanges();
        }

        public void Delete<TEntity>(int id) where TEntity : EntidadeBase
        {
            var entity = _context.Set<TEntity>().Find(id);
            _context.Remove<TEntity>(entity);
            _context.SaveChanges();
        }

        public IQueryable<TEntity> Query<TEntity>() where TEntity : EntidadeBase
        {
            return _context.Set<TEntity>();
        }

        public TEntity GetById<TEntity>(int id) where TEntity : EntidadeBase
        {
            return _context.Find<TEntity>(id);
        }

        public IQueryable<TEntity> QueryAsNoTracking<TEntity>() where TEntity : EntidadeBase
        {
            return _context.Set<TEntity>().AsNoTracking();
        }

    }
}
