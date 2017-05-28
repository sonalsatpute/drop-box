using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using DropboxStorageService;

namespace DropboxApi.Controllers
{
  [Route("api/[controller]")]
  public class TransferController : Controller
  {
    IHostingEnvironment _environment;

    public TransferController(IHostingEnvironment environment)
    {
      _environment = environment;
    }

    [HttpGet("status")]
    public IActionResult Status() => Ok(":) up and running yo!");

    [HttpPost]
    public IActionResult Post(IFormFile file)
    {
      if (file == null) return BadRequest("file missing");

      try
      {
        string uploadDirectoryPath = CreateUploadsDirectoryIfNotPresent();

        IStorageService storage = new DiskStorageService();
        storage.Store(file.OpenReadStream(), $"{uploadDirectoryPath}{file.FileName}");

        return Ok();
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.Message);
        return StatusCode(StatusCodes.Status500InternalServerError);
      }
    }

    private string CreateUploadsDirectoryIfNotPresent()
    {
      string uploadDirectoryPath = $"{_environment.ContentRootPath}\\uploads\\";

      if (!System.IO.File.Exists(uploadDirectoryPath))
        Directory.CreateDirectory(uploadDirectoryPath);

      return uploadDirectoryPath;
    }
    

    
  }
}