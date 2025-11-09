using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Ciurdarean_Patricia_Lab2.Data;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddDbContext<Ciurdarean_Patricia_Lab2Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Ciurdarean_Patricia_Lab2Context") ??
        throw new InvalidOperationException("Connection string 'Ciurdarean_Patricia_Lab2Context' not found.")));

builder.Services.AddDbContext<LibraryIdentityContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Ciurdarean_Patricia_Lab2Context") ??
        throw new InvalidOperationException("Connection string 'Ciurdarean_Patricia_Lab2Context' not found.")));

builder.Services.AddDefaultIdentity<IdentityUser>(options =>
{
    options.SignIn.RequireConfirmedAccount = true;
})
    .AddEntityFrameworkStores<Ciurdarean_Patricia_Lab2Context>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapRazorPages();

app.Run();
