using Microsoft.EntityFrameworkCore;
using moviebooking.Infrastructure;
using moviebooking.Application;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped<IMovieService, MovieService>();
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowFE", policy =>
    {
        policy.AllowAnyOrigin()   // Thả xích: Cho phép mọi nguồn (kể cả file:// từ ổ D) chọc vào
              .AllowAnyMethod()   // Cho phép dùng mọi hành động GET, POST, PUT, DELETE
              .AllowAnyHeader();  // Cho phép truyền mọi kiểu dữ liệu qua lại
    });
});
// Add services to the container.

builder.Services.AddControllers();
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

app.UseAuthorization();

app.UseCors("AllowFE"); // Kích hoạt chính sách thả xích vừa khai báo ở trên

app.MapControllers();

app.Run();
