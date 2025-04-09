using Microsoft.AspNetCore.Mvc;
using Application.Services;
using Microsoft.EntityFrameworkCore;
using InterfaceAdapters.DTOs;
namespace WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PersonsController : ControllerBase
{
    private readonly IFilterPersonUseCase _filterPersonUseCase;
    private readonly IAddPersonUseCase _addPersonUseCase;
    private readonly IUpdatePersonUseCase _updatePersonUseCase;
    private readonly IDeletePersonUseCase _deletePersonUseCase;

    public PersonsController(IFilterPersonUseCase filterPersonUseCase, IAddPersonUseCase addPersonUseCase, IUpdatePersonUseCase updatePersonUseCase, IDeletePersonUseCase deletePersonUseCase)
    {
        _filterPersonUseCase = filterPersonUseCase;
        _addPersonUseCase = addPersonUseCase;
        _updatePersonUseCase = updatePersonUseCase;
        _deletePersonUseCase = deletePersonUseCase;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll([FromQuery] FilterPersonQuery query)
    {

        var persons = await _filterPersonUseCase.Execute(query).ToListAsync();

        return Ok(persons);
    }

    [HttpPost]
    public async Task<IActionResult> CreatePerson([FromBody] PersonUpdateCreateRequestDTO person)
    {

        var createdPerson = await _addPersonUseCase.Execute(person);

        return StatusCode(201, createdPerson);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdatePerson(Guid id, [FromBody] PersonUpdateCreateRequestDTO person)
    {
        try
        {
            var updatedPerson = await _updatePersonUseCase.Execute(id, person);

            return Ok(updatedPerson);
        }
        catch (KeyNotFoundException e)
        {
            return NotFound(e.Message);
        }

    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeletePerson(Guid id)
    {
        try
        {
            await _deletePersonUseCase.Execute(id);
            return NoContent();
        }
        catch (KeyNotFoundException e)
        {
            return NotFound(e.Message);
        }
    }
}
