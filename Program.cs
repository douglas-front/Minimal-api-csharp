using UserApi.Models;
using UserApi.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.MapGet("/", ()=>{

    ConnectionDB connectionDB = new();

    // List<UserModel> users = [];
    // users.Add(new UserModel { Id = 1, UserName = "douglas", Contact = "81 982671743"});

    return "ok";
});

app.Run();