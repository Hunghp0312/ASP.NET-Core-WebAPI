using Assignment1.Persistence;
using InterfaceAdapters.Gateways;
using Microsoft.EntityFrameworkCore;
using Application.UseCase;
using InterfaceAdapters.Presenters;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped<ITodoRepository, TodoRepository>();
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped<IGetAllTodoUseCase, GetAllTodoUseCase>();
builder.Services.AddScoped<IGetByIdTodoUseCase, GetByIdTodoUseCase>();
builder.Services.AddScoped<ICreateTodoUseCase, CreateTodoUseCase>();
builder.Services.AddScoped<IUpdateTodoUseCase, UpdateTodoUseCase>();
builder.Services.AddScoped<IDeleteTodoUseCase, DeleteTodoUseCase>();
builder.Services.AddScoped<IBulkDeleteTodoUseCase, BulkDeleteTodoUseCase>();
builder.Services.AddScoped<IBulkCreateTodoUseCase, BulkCreateTodoUseCase>();
builder.Services.AddScoped<ITodoPresenter, TodoPresenter>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
