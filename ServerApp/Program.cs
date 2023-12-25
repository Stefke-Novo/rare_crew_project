using Microsoft.EntityFrameworkCore;
using ServerApp;
using ServerApp.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
string server = builder.Configuration["Data:CommandAPIConnection:ConnectionString"];
//builder.Services.AddDbContext<ExampleContext>(opt => opt.UseSqlServer(server));
builder.Services.AddDbContext<DBContext>(opt => opt.UseSqlServer(server));
builder.Services.AddScoped<IEmployeeService, EmployeeService>();
string myCors = "MySpecificOrigins";
builder.Services.AddCors(options => options.AddPolicy(name: myCors, policy => {
    policy.WithOrigins("http://localhost:4200/").AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
}));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors(myCors);

app.UseAuthorization();

app.MapControllers();

app.Run();
