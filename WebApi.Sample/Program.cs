var builder = WebApplication.CreateBuilder(args);

//Service Registration

builder.Services.AddControllers(); //Api controller lar�n� ekleyebilmek i�in gereklidir. MVC Views deste�i yoktur mvc controller i�in AddControllersWithViews() (Hem api hem MVC View deste�ini ekler) service kayd�n� yapmal�s�n. AddRazorPages() sadece Razor Pages deste�i ekler.






var app = builder.Build();

//Middlewares

app.MapControllers(); //AddControllers(); ile eklenen controller lar� kullanabilmek (y�nlendirilmesi (routing)) i�in gereklidir.

app.Run();
