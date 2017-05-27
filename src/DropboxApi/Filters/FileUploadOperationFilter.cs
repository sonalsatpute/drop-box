using Swashbuckle.AspNetCore.SwaggerGen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Swashbuckle.AspNetCore.Swagger;

namespace DropboxApi.Filters
{
  public class FileUploadOperationFilter : IOperationFilter
  {
    public void Apply(Operation operation, OperationFilterContext context)
    {
      if (operation.OperationId.ToLower() == "apitransferpost")
      {
        operation.Parameters.Clear();
        operation.Parameters.Add(new NonBodyParameter
        {
          Name = "file",
          In = "formData",
          Description = "Upload File",
          Required = true,
          Type = "file"
        });
        operation.Consumes.Add("multipart/form-data");
      }
    }
  }
}
