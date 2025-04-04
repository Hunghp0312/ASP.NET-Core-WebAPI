using Microsoft.AspNetCore.Mvc;
using Domain;
using Application.UseCase;
using InterfaceAdapters.Presenters;
namespace Assignment1.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TodosController : ControllerBase
{
    private readonly IGetAllTodoUseCase _getAllTodoUseCase;
    private readonly IGetByIdTodoUseCase _getByIdTodoUseCase;
    private readonly ICreateTodoUseCase _createTodoUseCase;
    private readonly IUpdateTodoUseCase _updateTodoUseCase;
    private readonly IDeleteTodoUseCase _deleteTodoUseCase;
    private readonly IBulkDeleteTodoUseCase _bulkDeleteTodoUseCase;
    private readonly IBulkCreateTodoUseCase _bulkCreateTodoUseCase;
    private readonly ITodoPresenter _todoPresenter;
    public TodosController
        (IGetAllTodoUseCase getAllTodoUseCase, IGetByIdTodoUseCase getByIdTodoUseCase,
        ICreateTodoUseCase createTodoUseCase, IUpdateTodoUseCase updateTodoUseCase,
        IDeleteTodoUseCase deleteTodoUseCase, IBulkDeleteTodoUseCase bulkDeleteTodoUseCase,
        IBulkCreateTodoUseCase bulkCreateTodoUseCase, ITodoPresenter todoPresenter)
    {
        _getAllTodoUseCase = getAllTodoUseCase;
        _getByIdTodoUseCase = getByIdTodoUseCase;
        _createTodoUseCase = createTodoUseCase;
        _updateTodoUseCase = updateTodoUseCase;
        _deleteTodoUseCase = deleteTodoUseCase;
        _bulkDeleteTodoUseCase = bulkDeleteTodoUseCase;
        _bulkCreateTodoUseCase = bulkCreateTodoUseCase;
        _todoPresenter = todoPresenter;
    }
    [HttpGet]
    public async Task<IActionResult> GetAllTodos()
    {
        var todos = await _getAllTodoUseCase.Execute();
        var todosResponse = _todoPresenter.PresentAllTodos(todos);
        return Ok(todos);
    }
    [HttpGet("{id}")]
    public async Task<IActionResult> GetTodoById(Guid id)
    {
        var todo = await _getByIdTodoUseCase.Execute(id);
        if (todo == null)
        {
            return NotFound();
        }
        var todoResponse = _todoPresenter.PresentTodo(todo);
        return Ok(todo);
    }
    [HttpPost]
    public async Task<IActionResult> CreateTodo([FromBody] Todo todo)
    {

        var createdTodo = await _createTodoUseCase.Execute(todo);
        var createdTodoResponse = _todoPresenter.PresentTodo(createdTodo);
        return StatusCode(201, createdTodo);
    }
    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateTodo(Guid id, [FromBody] Todo todo)
    {
        var updatedTodo = await _updateTodoUseCase.Execute(todo);
        if (updatedTodo == null)
        {
            return NotFound();
        }
        var updatedTodoResponse = _todoPresenter.PresentTodo(updatedTodo);
        return Ok(updatedTodo);
    }
    [HttpDelete]
    public async Task<IActionResult> DeleteTodo(Guid id)
    {
        await _deleteTodoUseCase.Execute(id);
        return NoContent();
    }
    [HttpDelete("bulk")]
    public async Task<IActionResult> BulkDeleteTodos([FromBody] List<Guid> ids)
    {
        await _bulkDeleteTodoUseCase.Execute(ids);
        return NoContent();
    }
    [HttpPost("bulk")]
    public async Task<IActionResult> BulkCreateTodos([FromBody] List<Todo> todos)
    {
        var createdTodos = await _bulkCreateTodoUseCase.Execute(todos);
        var createdTodoResponse = _todoPresenter.PresentAllTodos(createdTodos);
        return StatusCode(201, createdTodoResponse);
    }
}
