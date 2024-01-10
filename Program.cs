using TwoToFour.Services.AddSum;
using TwoToFour.Services.CompareNums;
using TwoToFour.Services.WakeUpTime;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IAddSumService, AddSumService>();
builder.Services.AddScoped<ICompareNumsService, CompareNumsService>();
builder.Services.AddScoped<IWakeUpTimeService, WakeUpTimeService>();

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
