using Domain;
using InterfaceAdapters.DTOs;

namespace Application.Services;

public interface IUpdatePersonUseCase
{
    Task<Person> Execute(Guid id, PersonUpdateCreateRequestDTO personUpdateCreateDTO);
}
