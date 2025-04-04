using InterfaceAdapters.Gateways;
using Domain;
namespace Application.UseCase
{
    public class GetAllTodoUseCase: IGetAllTodoUseCase
    {
        private readonly ITodoRepository _todoRepository;
        public GetAllTodoUseCase(ITodoRepository todoRepository)
        {
            _todoRepository = todoRepository;
        }
        public async Task<IEnumerable<Todo>> Execute()
        {
            return await _todoRepository.GetAllAsync();
        }
    
    }
}
