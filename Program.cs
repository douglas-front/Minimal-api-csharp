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

app.MapGet("/", () =>
{
    ConnectionDB connectionDB = new();
    List<UserModel> users = connectionDB.GetUsers();
    return users;
});

app.MapPost("/post", () =>
{
    try
    {
        ConnectionDB connectionDB = new();

        UserModel user = new UserModel() { UserName = "Douglas", Contact = "81 972561623" };
        connectionDB.PostUser(user);
        return "Usuario adicionado com sucesso";
    }
    catch (System.Exception)
    {

        throw new Exception("erro ao adicionar");
    }
});

app.Run();