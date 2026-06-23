var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
var app = builder.Build();
app.Use(async (context, next) =>
{
    Console.WriteLine("Request Started");

    await next();

    Console.WriteLine("Request Ended");
});

app.MapControllers();

app.Run();