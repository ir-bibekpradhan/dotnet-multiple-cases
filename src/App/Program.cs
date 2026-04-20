using Newtonsoft.Json;
using Serilog;

Log.Logger = new LoggerConfiguration()
    .WriteTo.Console()
    .CreateLogger();

var packages = new[]
{
    "Newtonsoft.Json", "Serilog", "Serilog.Sinks.Console",
    "Microsoft.Extensions.Http", "Microsoft.Extensions.DependencyInjection",
    "Dapper", "FluentValidation"
};

Log.Information("Installed packages: {Packages}", JsonConvert.SerializeObject(packages));
Log.Information("App running on .NET {Version}", Environment.Version);
