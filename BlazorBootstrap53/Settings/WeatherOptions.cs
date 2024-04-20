using System.ComponentModel.DataAnnotations;

namespace BlazorBootstrap53.Settings;

public class WeatherOptions
{
  public const string ConfigSection = "Weather";
  [Required]
  public int ForecastDays { get; set; }

  public static void LoadAndValidate(ConfigurationManager config)
  {
    var section = config.GetSection(ConfigSection);
    if(section is null || !section.Exists())
    {
      throw new ArgumentNullException(nameof(section));
    }
    var days = section.GetValue<int>(nameof(ForecastDays));
    if(days < 1 || days > 14)
    {
      throw new ArgumentOutOfRangeException(nameof(ForecastDays)
       , $"Configured value {days} must be between 1 and 14.");
    }
  }
}
