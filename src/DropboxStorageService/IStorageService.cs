using System.IO;

namespace DropboxStorageService
{
  public interface IStorageService
  {
    void Store(Stream inputStream, string fileName);
  }
}
