var builder = WebApplication.CreateBuilder(args);

Console.WriteLine("Welcome to ECommerce Portal for Selling Fresh Flowers Startup");

Console.WriteLine("External Service Configuration Started");
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}


Console.WriteLine("Middleware Configuration Started");

app.UseHttpsRedirection();
app.UseRouting();
app.UseAuthorization();


Console.WriteLine("Static Files Configuration Started");

app.MapStaticAssets();

Console.WriteLine("Routing Configuration Started");
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


Console.WriteLine("Application Started Successfully and Listening to the Requests");
app.Run();
