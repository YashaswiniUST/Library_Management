

using BookManagement.API.Data;
using BookManagement.API.Services;
using Microsoft.EntityFrameworkCore;

var builder=WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<AppDbContext>(options=>options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped<IStudentService,StudentService>();
builder.Services.AddScoped<IStudentAuthService,StudentAuthService>();
builder.Services.AddScoped<IAdminAuthService,AdminAuthService>();
builder.Services.AddScoped<IAdminService,AdminService>();
var app=builder.Build();
if(app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
//app.UseHttpsRedirection();
app.UseCors("AllowBlazor");

app.MapControllers();
app.Run();