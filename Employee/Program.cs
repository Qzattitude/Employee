using Employee.Controllers.DB_Controller;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Serialization;
using Employee.Controllers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


builder.Services.AddControllers()
   .AddNewtonsoftJson(options => 
   options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json
   .ReferenceLoopHandling.Ignore).AddNewtonsoftJson(options=> options.SerializerSettings.ContractResolver 
    = new DefaultContractResolver());


builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
);


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

app.MapControllers();


app.Run();
