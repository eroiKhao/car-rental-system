using CarRentalSystem.Generic.Models;
using Microsoft.EntityFrameworkCore;

namespace CarRentalSystem.Generic.Repositories
{
    public class Repository<T> : IRepository<T> where T : Entity
    {
        protected readonly DbContext _context;
        protected readonly DbSet<T> _dbSet;
        public Repository(DbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }
        public virtual void Add(T entity)
        {
            _dbSet.Add(entity);
        }
        public virtual void Delete(T entity)
        {
            _dbSet.Remove(entity);
        }
        public virtual IEnumerable<T> GetAll()
        {
            return _dbSet.ToList();
        }
        public virtual T GetById(int id)
        {
            return _dbSet.Find(id);
        }
        public virtual void Update(T entity)
        {
            _dbSet.Update(entity);
        }
    }
}