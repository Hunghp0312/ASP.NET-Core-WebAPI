
namespace Application.Services;

public interface IDeletePersonUseCase
{
    Task<bool> Execute(Guid id);
}
