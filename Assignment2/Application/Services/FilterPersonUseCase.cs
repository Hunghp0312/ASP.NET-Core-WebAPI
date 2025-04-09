using Domain;
using InterfaceAdapters.Gateways;
namespace Application.Services;

public class FilterPersonUseCase : IFilterPersonUseCase
{
    private readonly IPersonRepository _personRepository;
    public FilterPersonUseCase(IPersonRepository personRepository)
    {
        _personRepository = personRepository;
    }
    public IQueryable<Person> Execute(FilterPersonQuery query)
    {
        var people = _personRepository.GetAll();
        
        if (!string.IsNullOrEmpty(query.Name))
        {
            people = people.Where(p => (p.FirstName + " " + p.LastName).Contains(query.Name));
        }
        if (query.Gender.HasValue)
        {
            people = people.Where(p => p.Gender == query.Gender);
        }
        if (!string.IsNullOrEmpty(query.BirthPlace))
        {
            people = people.Where(p => p.BirthPlace.Contains(query.BirthPlace));
        }
        return people; // ToListAsync requires Microsoft.EntityFrameworkCore
    }
}

