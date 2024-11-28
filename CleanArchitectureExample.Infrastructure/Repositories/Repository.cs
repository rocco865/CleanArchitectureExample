using CleanArchitectureExample.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitectureExample.Infrastructure.Repositories
{
    internal class Repository<T> : IRepository<T> where T : class
    {
        private readonly AppDbContext _context; 
        private readonly DbSet<T>? _dbSet;

        public Repository(AppDbContext context) 
        { 
            _context = context; 
            _dbSet = context.Set<T>(); 
        }
        public async Task AddAsync(T entity)
        {
            await _dbSet.AddAsync(entity); await _context.SaveChangesAsync();
        }

        public async void Delete(T entity)
        {
            _dbSet.Remove(entity); 
            _context.SaveChanges();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<T> GetByIdAsync(Guid id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async void Update(T entity)
        {
            _dbSet.Update(entity); 
            _context.SaveChanges();
        }
    }
}
