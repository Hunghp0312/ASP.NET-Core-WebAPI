using Microsoft.EntityFrameworkCore;
using InterfaceAdapters.Gateways;
namespace Assignment1.Persistence;

public class Repository<T> : IRepository<T> where T : class
{
    protected readonly AppDbContext _context;
    protected readonly DbSet<T> _dbSet;

    public Repository(AppDbContext context)
    {
        _context = context;
        _dbSet = _context.Set<T>();
    }

    public async Task<IEnumerable<T>> GetAllAsync()
    {
        var test = await _dbSet.ToListAsync();
        return await _dbSet.ToListAsync();
    }

    public async Task<T?> GetByIdAsync(Guid id)
    {
        return await _dbSet.FindAsync(id);
    }

    public async Task<T> CreateAsync(T entity)
    {
        await _dbSet.AddAsync(entity);
        await _context.SaveChangesAsync();
        return entity;
    }

    public async Task<T> UpdateAsync(T entity)
    {
        _dbSet.Update(entity);
        await _context.SaveChangesAsync();
        return entity;

    }

    public async Task DeleteAsync(Guid id)
    {
        // Find the entity by its ID
        var entity = await _dbSet.FindAsync(id);

        // If entity not found, throw exception or handle accordingly
        if (entity == null)
        {
            throw new KeyNotFoundException($"Entity with ID {id} not found.");
        }

        _dbSet.Remove(entity); // Mark entity for removal
        await _context.SaveChangesAsync(); // Save changes to the database
    }

}
