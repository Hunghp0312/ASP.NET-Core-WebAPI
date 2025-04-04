
using Domain;

namespace Application.UseCase;

public interface IBulkCreateTodoUseCase
{
    Task<IEnumerable<Todo>> Execute(IEnumerable<Todo> todos);
}
