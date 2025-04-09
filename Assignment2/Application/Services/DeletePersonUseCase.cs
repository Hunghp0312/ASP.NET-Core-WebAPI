using InterfaceAdapters.Gateways;
using System;

namespace Application.Services;

public class DeletePersonUseCase : IDeletePersonUseCase
{
    private readonly IPersonRepository _personRepository;
    public DeletePersonUseCase(IPersonRepository personRepository)
    {
        _personRepository = personRepository;
    }
    public async Task<bool> Execute(Guid id)
    {
        await _personRepository.DeleteAsync(id);
        return true;
    }
}
