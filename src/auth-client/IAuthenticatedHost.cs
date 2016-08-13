using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Sar.Services;

namespace Sar.Services.Auth
{
  public interface IAuthenticatedHost : IHost
  {
    ClaimsPrincipal User { get; }
    string AccessToken { get; }
  }
}
