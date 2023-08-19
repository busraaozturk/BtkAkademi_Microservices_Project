using BtkAkademi.Service.ChatAPI.Hubs;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddPolicy("CorsPolicy", builder => builder
        .WithOrigins("https://localhost:7243")
        .AllowAnyMethod()
        .AllowAnyHeader()
      .AllowCredentials()
      );
});

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddSignalR();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("CorsPolicy");

app.UseAuthorization();

app.MapHub<OrderHub>("/orderHub");
app.MapControllers();

app.Run();
