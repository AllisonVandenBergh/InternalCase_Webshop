﻿using Api.Endpoints.Internal;
using Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddEndpoints<Program>(builder.Configuration);
builder.Services.AddDbContext<WebshopContext>(options => options.UseSqlServer(builder.Configuration.GetValue<string>("Database:ConnectionString")));

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: "AllowedOrigins",
                        builder =>
                        {
                            builder.WithOrigins("http://localhost:5173");
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