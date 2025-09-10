var builder = WebApplication.CreateBuilder(args);


//Service registrations
builder.Services.AddControllersWithViews();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}


//Middleware registrations
//inbuit middlewres provided by asp.net runtime

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();


//Controller Route Mapping

//app url
//http://localhost:5000/Home/Index
//

app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("index.html");

app.Run();
