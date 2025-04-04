using Domain;

namespace Application.UseCase;

public interface IUpdateTodoUseCase
{
    Task<Todo> Execute(Todo todo);
}
