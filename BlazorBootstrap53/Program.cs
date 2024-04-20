using BlazorBootstrap53.Settings;
using Blazored.Toast;
using Serilog;
using System.Reflection;

Log.Logger = new LoggerConfiguration()
		.MinimumLevel.Debug()
		.MinimumLevel.Override("Microsoft.System", Serilog.Events.LogEventLevel.Warning)
		.WriteTo.Console()
		.WriteTo.Seq(
				Environment.GetEnvironmentVariable("SEQ_URL") ?? "http://localhost:5341")
				.Enrich.FromLogContext().Enrich.WithMachineName().Enrich.WithProcessId().Enrich.WithThreadId()
		.CreateLogger();

try
{
	Log.Information("Application Starting Up"); // Note 1

	string? assembly = Assembly.GetEntryAssembly()!.GetName().Name ?? "Assembly Unknown?";
	string? env = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") ?? "Environment Unknown?";
	Log.Warning("{Assembly}!{Class}; {Environment}", assembly, nameof(Program), env!);

	var builder = WebApplication.CreateBuilder(args);

	builder.Services.AddRazorPages();
	builder.Services.AddServerSideBlazor(); // Note 5: 
	builder.Services.AddBlazoredToast();

	Log.Logger.Information("Total services: {count}", builder.Services.Count);

	builder.Services.Configure<DonationSettings>(builder.Configuration.GetSection("DonationSettings"));

	Log.Logger.Debug("{Service} Configure then LoadAndValidate", nameof(WeatherOptions));
	builder.Services.Configure<WeatherOptions>(builder.Configuration.GetSection(WeatherOptions.ConfigSection));
	WeatherOptions.LoadAndValidate(builder.Configuration);

	//The lc argument opens up the rest of the Serilog configuration API,
	//so you can easily enrich your log events with additional properties and send events to more sinks.
	builder.Host.UseSerilog((ctx, lc) => lc
		.MinimumLevel.Information()
		.MinimumLevel.Override("Microsoft.System", Serilog.Events.LogEventLevel.Warning)
		.WriteTo.Seq(
				Environment.GetEnvironmentVariable("SEQ_URL") ?? "http://localhost:5341")
				.Enrich.FromLogContext().Enrich.WithMachineName().Enrich.WithProcessId().Enrich.WithThreadId());

	var app = builder.Build();

	if (!app.Environment.IsDevelopment())
	{
		app.UseExceptionHandler("/Error");
		app.UseHsts();
	}

	app.UseHttpsRedirection();
	app.UseStaticFiles();
	app.UseRouting();
	app.MapBlazorHub();
	app.MapFallbackToPage("/_Host");
	app.Run();
	
}
catch (Exception ex)
{
	Log.Logger.Fatal(ex, "The application failed to start correctly"); // Note 3
}
finally
{
	Log.CloseAndFlush(); // Note 2
}

// Note 4
record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
	public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}


/*
Note 1: because we are in static void Main, we have to use the static keyword Log.Information not LogInformation
				i.e. we can't use the ILogger right now we must use the Serilog logger
Note 2: If you have any log messages that are pending, then this will make sure they are written.
Note 3: What's the difference between `Log.Fatal` and `Log.Logger.Fatal`
Note 4: Adding a class (record) inside the `Program.cs`

*/