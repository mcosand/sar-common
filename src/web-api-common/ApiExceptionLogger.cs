namespace Sar.Web
{
  using System.Security.Claims;
  using System.Threading;
  using System.Threading.Tasks;
  using System.Web.Http.ExceptionHandling;
  using log4net;

  public class ApiExceptionLogger : IExceptionLogger
  {
    private readonly ILog _log;

    public ApiExceptionLogger(ILog log)
    {
      _log = log;
    }

    public Task LogAsync(ExceptionLoggerContext context, CancellationToken cancellationToken)
    {
      var identity = context.RequestContext?.Principal?.Identity as ClaimsIdentity;
      
      if (context.Exception is UserErrorException)
      {
        _log.Debug($"User error by {identity?.Name}", context.Exception);
      }
      _log.Error($"Unhandled API exception {identity?.Name}", context.Exception);
      return Task.FromResult(0);
    }
  }
}