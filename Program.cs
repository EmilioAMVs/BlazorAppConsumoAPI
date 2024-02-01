using BlazorAppConsumoAPI.Composite;
using BlazorAppConsumoAPI.Observer;
using BlazorAppConsumoAPI.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

var builder = WebApplication.CreateBuilder(args);

// Configuracion HttpClient con Url de la API
builder.Services.AddHttpClient("ApiService", client =>
{
    client.BaseAddress = new Uri(builder.Configuration["ApiSettings:BaseUrl"]);
});

builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddScoped<APITTHH>();

// Registra tus servicios aquí
builder.Services.AddScoped<BlazorAppConsumoAPI.Composite.IComponent, CompositeService>();

builder.Services.AddScoped<IRolDePagosService, RolDePagosService>();

builder.Services.AddScoped<CentroCostoStateService>();



var app = builder.Build();


app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
