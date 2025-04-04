using Domain;
using InterfaceAdapters.Gateways;

namespace Application.UseCase;

public class DeleteTodoUseCase : IDeleteTodoUseCase
{
    private readonly ITodoRepository _todoRepository;
    public DeleteTodoUseCase(ITodoRepository todoRepository)
    {
        _todoRepository = todoRepository;
    }
    public async Task Execute(Guid id)
    {
         await _todoRepository.DeleteAsync(id);
    }
}
