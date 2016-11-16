using System.IO;
using System.Security.Claims;

namespace Sar
{
  public interface IHost
  {
    ClaimsPrincipal User { get; }
    string GetConfig(string key);

    Stream OpenFile(string relativePath);

    bool FileExists(string relativePath);
  }
}
