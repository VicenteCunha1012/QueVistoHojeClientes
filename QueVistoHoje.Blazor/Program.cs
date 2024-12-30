using System.Net.Http; // Ensure this is included
using QueVistoHoje.Blazor.Components;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// Register HttpClient for dependency injection
builder.Services.AddScoped<HttpClient>(sp =>
    new HttpClient { BaseAddress = new Uri("https://xfwd3lsv-7119.uks1.devtunnels.ms/swagger/index.html") });

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
