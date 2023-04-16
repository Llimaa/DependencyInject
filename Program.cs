using DependencyInject.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Singleton
builder.Services.AddSingleton<IDateService, DateService>();
builder.Services.AddSingleton<Date02Service>();

// Scoped
// builder.Services.AddScoped<IDateService, DateService>();
// builder.Services.AddScoped<Date02Service>();

// Transient
// builder.Services.AddTransient<IDateService, DateService>();
// builder.Services.AddTransient<Date02Service>();

var app = builder.Build();

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
