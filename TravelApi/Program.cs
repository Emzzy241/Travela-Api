using Microsoft.EntityFrameworkCore;
using TravelApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Add CORS policy to allow requests from TravelClient
// builder.Services.AddCors(options =>
// {
//     options.AddPolicy("AllowTravelClient",
//         builder =>
//         {
//             builder.WithOrigins("http://localhost:5181")  // TravelClient's URL
//                    .AllowAnyHeader()
//                    .AllowAnyMethod();
//         });
// });

// builder.Services.AddCors(options =>
// {
//     options.AddPolicy("AllowAllOrigins",
//         builder =>
//         {
//             builder.AllowAnyOrigin()
//                    .AllowAnyMethod()
//                    .AllowAnyHeader();
//         });
// });

// Adding the middleware for our DbContext
builder.Services.AddDbContext<TravelApiContext>(
    dbContextOptions => dbContextOptions
        .UseMySql(
            builder.Configuration["ConnectionStrings:DefaultConnection"], 
            ServerVersion.AutoDetect(builder.Configuration["ConnectionStrings:DefaultConnection"])
        )
);

// Add Swagger services
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// // Enable CORS
// app.UseCors("AllowTravelClient");

// app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
