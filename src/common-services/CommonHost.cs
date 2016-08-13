using System.Configuration;

namespace Sar.Services
{
  public class CommonHost : IHost
  {
    public string GetConfig(string key)
    {
      return ConfigurationManager.AppSettings[key];
    }
  }
}
