using DockerMVC.Context;
using DockerMVC.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var host = builder.Configuration["DBHOST"] ?? "localhost";
var port = builder.Configuration["DBPORT"] ?? "3306";
var password = builder.Configuration["DBPASSWORD"] ?? "yma2578K";
var connectionString = $"Server={host};User=root;Password={password};Port={port};Database=produtosdb;AllowPublicKeyRetrieval=True";
Console.WriteLine($"=============================Connection String: {connectionString}");


builder.Services.AddDbContext<DatabaseContext>(options =>
{
    options.UseMySql(connectionString, new MySqlServerVersion(MySqlServerVersion.LatestSupportedServerVersion));
});

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddTransient<IRepository, Repository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

ApplyMigration.PopulateDatabase(app);


app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();