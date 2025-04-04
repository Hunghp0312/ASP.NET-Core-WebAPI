using Domain;
using InterfaceAdapters.DTOs;

namespace InterfaceAdapters.Presenters;

public class TodoPresenter : ITodoPresenter
{
    IEnumerable<TodoResponseDTO> ITodoPresenter.PresentAllTodos(IEnumerable<Todo> todos)
    {
        foreach(var todo in todos)
        {
            yield return new TodoResponseDTO
            {
                Id = todo.Id,
                Title = todo.Title,
                IsCompleted = todo.IsCompleted
            };
        }
    }


    TodoResponseDTO ITodoPresenter.PresentTodo(Todo todo)
    {
        return new TodoResponseDTO
        {
            Id = todo.Id,
            Title = todo.Title,
            IsCompleted = todo.IsCompleted
        };
    }
}
