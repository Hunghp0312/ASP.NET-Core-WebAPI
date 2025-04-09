using Domain;
using InterfaceAdapters.DTOs;
namespace Application.Services;

public interface IAddPersonUseCase
{
    Task<Person> Execute(PersonUpdateCreateRequestDTO person);
}
