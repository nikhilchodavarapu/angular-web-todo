var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAngular",
        policy =>
        {
            policy
                .WithOrigins("http://localhost:4200") // Angular URL
                .AllowAnyHeader()
                .AllowAnyMethod()
                .AllowCredentials();
        });
});


var app = builder.Build();

app.UseCors("AllowAngular");

app.Use(async (context, next) =>
{
    Console.WriteLine("Request Started");

    await next();

    Console.WriteLine("Request Ended");
});

app.MapControllers();

app.Run();