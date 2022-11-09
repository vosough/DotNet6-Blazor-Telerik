using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.Net.Http.Headers;
using proUserInfoManagement.Api.Data;
using proUserInfoManagement.Api.Repositories;
using proUserInfoManagement.Api.Repositories.Contracts;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContextPool<UserInfoManagementDbContext>(
    Options => Options.UseSqlServer(builder.Configuration.GetConnectionString("UserInfoManagement"))
    );
builder.Services.AddScoped<IUserRepository, UserRepository>();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
   
}
app.UseSwagger();
app.UseSwaggerUI();

app.UseCors(
    policy => policy.WithOrigins("http://localhost:7191", "https://localhost:7191").AllowAnyMethod()
    .WithHeaders(HeaderNames.ContentType)
    );


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
app.UseDeveloperExceptionPage();
app.Run();
