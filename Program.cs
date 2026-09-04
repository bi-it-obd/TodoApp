using MySqlConnector;
using TodoApp.Components;
using TodoApp.Repositories;
using MudBlazor.Services;

var builder = WebApplication.CreateBuilder(args);

var connectionString = new MySqlConnectionStringBuilder
{
    Server = "127.0.0.1",
    Port = 3306,
    Database = "TodoApp",
    UserID = "root",
    Password = File.ReadAllText("./secrets/mariadb_root_password").Trim()
}.ConnectionString;

builder.Services.AddScoped<ITaskRepository>(_ => new TaskRepository(connectionString));
builder.Services.AddMudServices();

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseStatusCodePagesWithReExecute("/not-found", createScopeForStatusCodePages: true);
app.UseHttpsRedirection();

app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
