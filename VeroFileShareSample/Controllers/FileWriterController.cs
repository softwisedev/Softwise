using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace VeroFileShareSample.Controllers
{
  [ApiController]
  [Route("file")]
  [AllowAnonymous]
  public class FileWriterController : ControllerBase
  {
    private static readonly string[] Summaries = new[]
    {
      "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<FileWriterController> _logger;

    public FileWriterController(ILogger<FileWriterController> logger)
    {
      _logger = logger;
    }

    [HttpPost]
    [Route("read")]
    public string Get(DFile file)
    {
      if (file == null)
      {
        return "Provide file name?";
      }
      try
      {
        return System.IO.File.ReadAllText($"{file.FilePath}/{file.FileName}");
      }
      catch
      {
        return "Couldn't find the file";
      }
    }

    [HttpPost]
    [Route("write")]
    public bool Create(DFile file)
    {
      if (file == null) return false;
      try
      {
        System.IO.File.WriteAllText($"{file.FilePath}/{file.FileName}", file.Text);
        return true;
      }
      catch 
      {
        return false;
      }
    }
  }
}
