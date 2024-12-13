using UserApi.Models;

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

    List<UserModel> users = [];
    users.Add(new UserModel { Id = 1, UserName = "douglas", Contact = "81 982671743"});

    return users;

}).WithDisplayName("GetUsers");

app.Run();