using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace Sar.Services.Auth
{
  public interface IAuthorizationService
  {
    Task<bool> AuthorizeAsync(ClaimsPrincipal user, object resource, string policyName);
  }

  public class AuthorizationService : IAuthorizationService
  {
    private readonly IUserInfoService _rolesService;

    public AuthorizationService(IUserInfoService rolesService)
    {
      _rolesService = rolesService;
    }

    public async Task<bool> AuthorizeAsync(ClaimsPrincipal user, object resource, string policyName)
    {
      var userInfo = await _rolesService.GetCurrentUserInfo();

      // Members can read their own records.
      if (policyName.StartsWith("Read:") && (policyName.EndsWith("@Member") || policyName.EndsWith(":Member")) && (Guid)resource == userInfo.MemberId)
      {
        return true;
      }

      Match m = Regex.Match(policyName, "^([a-zA-Z]+)(\\:([a-zA-Z]+)(@([a-zA-Z]+))?)?$");
      if (!m.Success) throw new InvalidOperationException("Unknown policy " + policyName);

      if (m.Groups[1].Value == "Read" && (
        userInfo.Roles.Any(f => f == "cdb.users")
        || userInfo.Scopes.Any(f => f.StartsWith("db-r-"))
        || userInfo.Scopes.Any(f => f.StartsWith("db-w-"))
        )) return true;

      if (m.Groups[1].Value == "Create" && (
        userInfo.Roles.Any(f => f == "cdb.admins")
        || userInfo.Scopes.Any(f => f.StartsWith("db-w-"))
        )) return true;
      return false;
    }
  }
}