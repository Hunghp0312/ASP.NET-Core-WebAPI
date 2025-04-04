using Domain;

namespace Application.UseCase;

public interface IGetByIdTodoUseCase
{
    Task<Todo?> Execute(Guid id);
}
