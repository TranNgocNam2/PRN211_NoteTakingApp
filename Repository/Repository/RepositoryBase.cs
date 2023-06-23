using Microsoft.EntityFrameworkCore;
using Repository.Models;

namespace NoteTakingApp.Repository
{
    public class RepositoryBase<T> where T : class
    {
        NoteTakingAppContext _context;
        DbSet<T> _dbSet;

        public RepositoryBase()
        {
            _context = new NoteTakingAppContext();
            _dbSet = _context.Set<T>();
        }

        public List<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public void Create(T entity)
        {
            _dbSet.Add(entity);
            _context.SaveChanges();
        }

        public Boolean Delete(T entity)
        {
            try
            {
                _dbSet.Remove(entity);
                _context.SaveChanges(true);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public void Update(T entity)
        {
            var tracker = _context.Attach(entity);
            tracker.State = EntityState.Modified;
            _context.SaveChanges(true);
        }
    }
}
