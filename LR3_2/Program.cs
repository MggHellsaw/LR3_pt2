using LR3_2.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddTransient<ITimeOfDayService, TimeOfDayService>();

var app = builder.Build();

app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapGet("/", async context =>
    {
        var timeOfDayService = context.RequestServices.GetRequiredService<ITimeOfDayService>();
        var timeOfDay = timeOfDayService.GetTimeOfDay();

        context.Response.ContentType = "text/html; charset=utf-8";

        await context.Response.WriteAsync($" {timeOfDay}!");
    });
});

app.Run();