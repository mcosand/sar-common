namespace Sar.WebApi
{
  public interface IWebApiHost : IHost
  {
    string RequestToken { get; }
  }
}
