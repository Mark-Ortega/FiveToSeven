using FiveToSeven.Services.MadLib;
using FiveToSeven.Services.OddOrEven;
using FiveToSeven.Services.ReverseItNum;
using FiveToSeven.Services.ReverseItStr;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IMadLibServices, MadLibServices>();
builder.Services.AddScoped<IOddOrEvenServices, OddOrEvenServices>();
builder.Services.AddScoped<IReverseItStrServices, ReverseItStrServices>();
builder.Services.AddScoped<IReverseItNumServices, ReverseItNumServices>();

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
