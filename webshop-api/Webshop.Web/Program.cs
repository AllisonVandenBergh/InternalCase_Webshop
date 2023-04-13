using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Webshop.Core.Infrastructure;
using Webshop.Web;
using Webshop.Web.Endpoints.Internal;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddEndpoints<Program>(builder.Configuration);
builder.Services.AddDbContext<WebshopContext>(options => options.UseSqlServer(builder.Configuration.GetValue<string>("Database:ConnectionString")));
builder.Services.AddValidatorsFromAssemblyContaining<Program>();

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: "AllowedOrigins",
                        builder =>
                        {
                            builder.WithOrigins("http://localhost:5173")
                                   .AllowAnyMethod()
                                   .AllowAnyHeader();
                        });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors("AllowedOrigins");
app.UseEndpoints<Program>();

app.Run();