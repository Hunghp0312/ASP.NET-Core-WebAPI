using Domain;
using InterfaceAdapters.DTOs;
namespace InterfaceAdapters.Presenters;

public interface ITodoPresenter
{
    IEnumerable<TodoResponseDTO> PresentAllTodos(IEnumerable<Todo> todos);
    TodoResponseDTO PresentTodo(Todo todo);
}
