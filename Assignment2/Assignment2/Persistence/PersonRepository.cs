using Domain;
using InterfaceAdapters.Gateways;
namespace WebApi.Persistence;

public class PersonRepository : Repository<Person>, IPersonRepository
{
    public PersonRepository(AppDbContext context) : base(context)
    {
    }

    public override async Task<Person> UpdateAsync(Person entity)
    {
        // Custom logic for updating a Person entity can be added here
        var person = await _dbSet.FindAsync(entity.Id) ?? throw new KeyNotFoundException($"Entity with ID {entity.Id} not found."); ;
        person.FirstName = entity.FirstName;
        person.LastName = entity.LastName;
        person.Gender = entity.Gender;
        person.DateOfBirth = entity.DateOfBirth;
        person.BirthPlace = entity.BirthPlace;
        await _context.SaveChangesAsync();

        return person;
    }
}

