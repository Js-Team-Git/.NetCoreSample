using Elastic.Apm.Api;
using Elastic.Apm.AspNetCore;
using System.Diagnostics;
using OpenTelemetry.Resources;
using OpenTelemetry.Trace;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddOpenTelemetry()
    .WithTracing(tracerProviderBuilder =>
        tracerProviderBuilder
            .AddSource(DiagnosticsConfig.ActivitySource.Name)
            .ConfigureResource(resource => resource
                .AddService(DiagnosticsConfig.ServiceName))
            .AddAspNetCoreInstrumentation());

builder.Services.AddControllers();
//builder.Services.ap();
var app = builder.Build();
app.UseElasticApm(app.Configuration);

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

//app.UseAllElasticApm(app.Configuration);
// Configure the HTTP request pipeline.

public static class DiagnosticsConfig
{
    public const string ServiceName = "my-service-aspdncore6";
    public static ActivitySource ActivitySource = new ActivitySource(ServiceName);
}




