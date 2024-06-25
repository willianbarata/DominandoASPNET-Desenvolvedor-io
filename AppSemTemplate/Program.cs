var builder = WebApplication.CreateBuilder(args);

//Um configuração mais simples, que o Add MVC
builder.Services.AddControllersWithViews();

var app = builder.Build();

//Usar as rotas
app.UseRouting();

//Para usar o roteamento
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
