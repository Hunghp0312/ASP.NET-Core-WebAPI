
using Domain;

namespace Application.UseCase;

public interface ICreateTodoUseCase
{
    Task<Todo> Execute(Todo todo);
}
