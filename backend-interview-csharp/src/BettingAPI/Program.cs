using BettingAPI.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<BettingDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Check DB connection on startup
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var logger = services.GetRequiredService<ILogger<Program>>();
    try
    {
        var context = services.GetRequiredService<BettingDbContext>();
        var cancellationTokenSource = new CancellationTokenSource(TimeSpan.FromSeconds(30));
        if (!await context.Database.CanConnectAsync(cancellationTokenSource.Token))
        {
            throw new Exception("Failed to connect to the database within the 30-second timeout.");
        }
        
        logger.LogInformation("Successfully connected to database.");
    }
    catch (Exception ex)
    {
        logger.LogError(ex, "An error occurred while connecting to the database. Application is shutting down.");
        // Re-throwing the exception will cause the application to crash, which is a clear
        // indication of a startup failure.
        throw;
    }
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
