using Domain;
namespace InterfaceAdapters.Gateways;

public interface ITodoRepository: IRepository<Todo>
{
    Task<IEnumerable<Todo>> BulkInsertTodoAsync(IEnumerable<Todo> todos);
    Task BulkDeleteTodo(IEnumerable<Guid> ids);
}
