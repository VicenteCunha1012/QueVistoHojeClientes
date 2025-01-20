using System.Net.Http; // Ensure this is included

using QueVistoHoje.Blazor.Components;
using QueVistoHoje.RCL.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// Register HttpClient for dependency injection
builder.Services.AddScoped<HttpClient>(sp =>
    new HttpClient { BaseAddress = new Uri("https://d3q8hwmm-7119.uks1.devtunnels.ms") });

builder.Services.AddSingleton<UserService>();
<<<<<<< HEAD
builder.Services.AddSingleton<APIService>();
=======
>>>>>>> 817da96e6c7472d81c14db231778c170d33ecb80

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment()) {
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode()
    .AddAdditionalAssemblies(typeof(QueVistoHoje.RCL._Imports).Assembly);

app.Run();
