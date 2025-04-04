
namespace InterfaceAdapters.DTOs;

public class TodoResponseDTO
{
    public Guid Id { get; set; }
    public required string Title { get; set; }
    public bool IsCompleted { get; set; }
}
