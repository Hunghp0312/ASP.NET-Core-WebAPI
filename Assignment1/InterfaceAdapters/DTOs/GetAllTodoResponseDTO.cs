
namespace InterfaceAdapters.DTOs;

public class GetAllTodoResponseDTO
{
    public IEnumerable<TodoResponseDTO> Todos { get; set; } = new List<TodoResponseDTO>();
    public int TotalCount { get; set; }
}
