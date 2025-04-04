
using Domain;
using InterfaceAdapters.Gateways;
namespace Application.UseCase;

public class BulkCreateTodoUseCase : IBulkCreateTodoUseCase
{
    private readonly ITodoRepository _todoRepository;
    public BulkCreateTodoUseCase(ITodoRepository todoRepository)
    {
        _todoRepository = todoRepository;
    }
    public async Task<IEnumerable<Todo>> Execute(IEnumerable<Todo> todos)
    {
        return await _todoRepository.BulkInsertTodoAsync(todos);
    }
}
