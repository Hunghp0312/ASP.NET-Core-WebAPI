using Domain;
using InterfaceAdapters.Gateways;

namespace Application.UseCase;

public class BulkDeleteTodoUseCase : IBulkDeleteTodoUseCase
{
    private readonly ITodoRepository _todoRepository;
    public BulkDeleteTodoUseCase(ITodoRepository todoRepository)
    {
        _todoRepository = todoRepository;
    }
    public async Task Execute(IEnumerable<Guid> ids)
    {
        await _todoRepository.BulkDeleteTodo(ids);
    }
}
