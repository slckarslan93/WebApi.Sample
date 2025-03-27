using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

//Service Registration

builder.Services.AddControllers(); //Api controller larýný ekleyebilmek için gereklidir. MVC Views desteði yoktur mvc controller için AddControllersWithViews() (Hem api hem MVC View desteðini ekler) service kaydýný yapmalýsýn. AddRazorPages() sadece Razor Pages desteði ekler.
builder.Services.AddOpenApi();

builder.Services.AddCors();


var app = builder.Build();

//Middlewares

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference();
}

app.MapGet("/", (int age) =>
{
    return Results.Ok();
});


app.UseCors(x => x.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());

app.MapControllers(); //AddControllers(); ile eklenen controller larý kullanabilmek (yönlendirilmesi (routing)) için gereklidir.

app.Run();
