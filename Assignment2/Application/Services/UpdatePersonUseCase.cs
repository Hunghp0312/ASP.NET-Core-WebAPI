
using Domain;
using InterfaceAdapters.DTOs;
using InterfaceAdapters.Gateways;

namespace Application.Services;

public class UpdatePersonUseCase : IUpdatePersonUseCase
{
    private readonly IPersonRepository _personRepository;
    public UpdatePersonUseCase(IPersonRepository personRepository)
    {
        _personRepository = personRepository;
    }
    public async Task<Person> Execute(Guid id, PersonUpdateCreateRequestDTO personUpdateCreateDTO)
    {
        Person person = new Person
        {
            Id = id,
            FirstName = personUpdateCreateDTO.FirstName,
            LastName = personUpdateCreateDTO.LastName,
            DateOfBirth = personUpdateCreateDTO.DateOfBirth,
            Gender = personUpdateCreateDTO.Gender,
            BirthPlace = personUpdateCreateDTO.BirthPlace
        };
        return await _personRepository.UpdateAsync(person);
    }

}
