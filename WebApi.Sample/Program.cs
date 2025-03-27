using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

//Service Registration

builder.Services.AddControllers(); //Api controller lar�n� ekleyebilmek i�in gereklidir. MVC Views deste�i yoktur mvc controller i�in AddControllersWithViews() (Hem api hem MVC View deste�ini ekler) service kayd�n� yapmal�s�n. AddRazorPages() sadece Razor Pages deste�i ekler.
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

app.MapControllers(); //AddControllers(); ile eklenen controller lar� kullanabilmek (y�nlendirilmesi (routing)) i�in gereklidir.

app.Run();
