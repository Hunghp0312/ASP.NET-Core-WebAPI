using InterfaceAdapters.Gateways;
using Domain;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Assignment1.Persistence
{
    public class TodoRepository: Repository<Todo>, ITodoRepository
    {
        public TodoRepository(AppDbContext context) : base(context)
        {
        }
        public async Task<IEnumerable<Todo>> BulkInsertTodoAsync(IEnumerable<Todo> todos)
        {
            await _dbSet.AddRangeAsync(todos);
            await _context.SaveChangesAsync();
            return todos;
        }

        public async Task BulkDeleteTodo(IEnumerable<Guid> ids)
        {
            var tasksToDelete = await _dbSet
                                       .Where(t => ids.Contains(t.Id))
                                       .ToListAsync();

            _dbSet.RemoveRange(tasksToDelete);
            await _context.SaveChangesAsync();
        }
    }
    
    
}
