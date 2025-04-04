using Domain;
using InterfaceAdapters.Gateways;

namespace Application.UseCase;

public class UpdateTodoUseCase : IUpdateTodoUseCase
{
    private readonly ITodoRepository _todoRepository;
    public UpdateTodoUseCase(ITodoRepository todoRepository)
    {
        _todoRepository = todoRepository;
    }
    public async Task<Todo> Execute(Todo todo)
    {
        return await _todoRepository.UpdateAsync(todo);
    }
}
