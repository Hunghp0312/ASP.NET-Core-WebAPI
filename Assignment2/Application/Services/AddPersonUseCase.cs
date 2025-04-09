using InterfaceAdapters.Gateways;
using Domain;
using InterfaceAdapters.DTOs;
namespace Application.Services;

public class AddPersonUseCase : IAddPersonUseCase
{
    private readonly IPersonRepository _personRepository;
    public AddPersonUseCase(IPersonRepository personRepository)
    {
        _personRepository = personRepository;
    }
    public async Task<Person> Execute(PersonUpdateCreateRequestDTO personUpdateCreateDTO)
    {
        Person person = new Person(personUpdateCreateDTO.FirstName, personUpdateCreateDTO.LastName, personUpdateCreateDTO.DateOfBirth, personUpdateCreateDTO.Gender, personUpdateCreateDTO.BirthPlace);
        return await _personRepository.CreateAsync(person);
    }
}
