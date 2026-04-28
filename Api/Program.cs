using Application;
using Persistence;
using Infrastructure;
using Scalar.AspNetCore;
using Api.Generated;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddApplicationServices();
builder.Services.AddRepositories();
builder.Services.AddInfrastructureServices();

builder.Services.AddCors();
builder.Services.AddOpenApi();

var app = builder.Build();


app.MapOpenApi();
app.MapScalarApiReference();

app.UseCors(builder => builder
.AllowAnyHeader()
.AllowAnyMethod()
.SetIsOriginAllowed((host) => true)
.AllowCredentials());
app.UseHttpsRedirection();
app.MapGeneratedEndpoints();
app.Run();
