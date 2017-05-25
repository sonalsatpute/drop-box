using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace DropboxApi.Controllers
{
  [Route("api/[controller]")]
  public class TransferController : Controller
  {
    //IHostingEnvironment _environment;

    //public TransferController(IHostingEnvironment environment)
    //{
    //  _environment = environment;
    //}
    [HttpGet]
    public IEnumerable<string> Get()
    {
      return new string[] { "value1", "value2" };
    }

    [HttpPost]
    public void Post(IFormFile _fromFile)
      /*[FileExtensions(Extensions = "jpg,jpeg")]*/
    {
      //  var filePath = $"{_environment.WebRootPath}/uploads/{_fromFile.FileName}";
      //  try
      //  {
      //    using (var stream = System.IO.File.OpenWrite(filePath))
      //    {
      //      _fromFile.CopyToAsync(stream);
      //    }

      //    return Ok();
      //  }
      //  catch
      //  {
      //    //TODO: log the execption
      //    return StatusCode(StatusCodes.Status500InternalServerError);
      //  }
      //return Ok();
    }
  }
}