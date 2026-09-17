using MoneyJudgement.Modules.Identity;
using MoneyJudgement.Modules.GroupManagement;
using MoneyJudgement.Modules.BillSplitting;
using MoneyJudgement.Modules.Settlement;
using MoneyJudgement.Modules.Reporting;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Register module DbContexts
builder.Services.AddIdentityModule(builder.Configuration);
builder.Services.AddGroupManagementModule(builder.Configuration);
builder.Services.AddBillSplittingModule(builder.Configuration);
builder.Services.AddSettlementModule(builder.Configuration);
builder.Services.AddReportingModule(builder.Configuration);

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection();

var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

app.MapGet("/weatherforecast", () =>
{
    var forecast =  Enumerable.Range(1, 5).Select(index =>
        new WeatherForecast
        (
            DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            Random.Shared.Next(-20, 55),
            summaries[Random.Shared.Next(summaries.Length)]
        ))
        .ToArray();
    return forecast;
})
.WithName("GetWeatherForecast");

app.Run();

record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
