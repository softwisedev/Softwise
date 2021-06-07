using System;

namespace VeroFileShareSample
{
  public class DFileForecast
  {
    public DateTime Date { get; set; }

    public int TemperatureC { get; set; }

    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

    public string Summary { get; set; }
  }

  public class DFile
  {
    public DateTime Date { get; set; }

    public string FilePath { get; set; }

    public string FileName { get; set; }
    
    public string Text { get; set; }

    public bool Success { get; set; }
  }
}
