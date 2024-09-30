using Microsoft.EntityFrameworkCore;
using trabalhoClientes.Context;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<trabalhoClientes.Context.AppCont>(options =>
{
    options.UseSqlServer(builder

        .Configuration
        .GetConnectionString("Client"));
});

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

AppDbInitializer.Seed(app);

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Cadastro}/{action=Index}/{id?}");

app.Run();
