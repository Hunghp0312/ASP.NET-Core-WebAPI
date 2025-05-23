using WebApi.Persistence;
using Microsoft.EntityFrameworkCore;
using Application.Services;
using InterfaceAdapters.Gateways;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped<IPersonRepository, PersonRepository>();
builder.Services.AddScoped<IFilterPersonUseCase, FilterPersonUseCase>();
builder.Services.AddScoped<IAddPersonUseCase, AddPersonUseCase>();
builder.Services.AddScoped<IUpdatePersonUseCase, UpdatePersonUseCase>();
builder.Services.AddScoped<IDeletePersonUseCase, DeletePersonUseCase>();

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
