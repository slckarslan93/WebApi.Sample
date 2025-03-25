var builder = WebApplication.CreateBuilder(args);

//Service Registration

builder.Services.AddControllers(); //Api controller larýný ekleyebilmek için gereklidir. MVC Views desteði yoktur mvc controller için AddControllersWithViews() (Hem api hem MVC View desteðini ekler) service kaydýný yapmalýsýn. AddRazorPages() sadece Razor Pages desteði ekler.






var app = builder.Build();

//Middlewares

app.MapControllers(); //AddControllers(); ile eklenen controller larý kullanabilmek (yönlendirilmesi (routing)) için gereklidir.

app.Run();
