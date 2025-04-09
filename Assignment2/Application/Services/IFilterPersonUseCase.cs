using Domain;
namespace Application.Services;

public interface IFilterPersonUseCase
{
    IQueryable<Person> Execute(FilterPersonQuery query);
}
