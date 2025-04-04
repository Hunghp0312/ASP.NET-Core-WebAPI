using Domain;

namespace Application.UseCase;

public interface IGetAllTodoUseCase
{
    Task<IEnumerable<Todo>> Execute();
}
