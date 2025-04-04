using Domain;
using InterfaceAdapters.Gateways;
namespace Application.UseCase;

public class CreateTodoUseCase :ICreateTodoUseCase
{
    private readonly ITodoRepository _todoRepository;
    public CreateTodoUseCase(ITodoRepository todoRepository)
    {
        _todoRepository = todoRepository;
    }
    public async Task<Todo> Execute(Todo todo)
    {
        return await _todoRepository.CreateAsync(todo);
    }
}
