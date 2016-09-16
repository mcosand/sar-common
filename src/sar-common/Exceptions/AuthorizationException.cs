using System;

namespace Sar
{
  public class AuthorizationException : ApplicationException
  {
    public AuthorizationException(string message = "Access Denied") : base(message)
    {
    }
  }
}
