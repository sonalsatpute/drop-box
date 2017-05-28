using System;
using System.IO;

namespace DropboxStorageService
{

  public class DiskStorageService : IStorageService
  {
    public void Store(Stream inputStream, string fileName)
    {
      using (FileStream fileStream = File.Create(fileName))
      {
        inputStream.CopyTo(fileStream);
      }
    }
  }
}
