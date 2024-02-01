using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Data
{
    public abstract class SqlDataManager<T> where T : class
    {
        protected readonly ApplicationDbContext _context;
        protected DbSet<T> _dbSet;

        public SqlDataManager(ApplicationDbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        protected async Task<bool> CreateAsync(T entity)
        {
            _dbSet.Add(entity);
            await _context.SaveChangesAsync();
            return true;
        }

        protected async Task<bool> UpdateAsync(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return true;
        }

        protected async Task<bool> DeleteAsync(int id)
        {
            var entity = await _dbSet.FindAsync(id);
            if (entity == null)
            {
                return false;
            }
            _dbSet.Remove(entity);
            await _context.SaveChangesAsync();
            return true;
        }

        protected async Task<T> GetByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        protected async Task<List<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }
    }
}