using Domain;   
using InterfaceAdapters.Gateways;
namespace Application.UseCase;

public class GetByIdTodoUseCase : IGetByIdTodoUseCase
{
    private readonly ITodoRepository _todoRepository;
    public GetByIdTodoUseCase(ITodoRepository todoRepository)
    {
        _todoRepository = todoRepository;
    }
    public async Task<Todo?> Execute(Guid id)
    {
        return await _todoRepository.GetByIdAsync(id);
    }
}
