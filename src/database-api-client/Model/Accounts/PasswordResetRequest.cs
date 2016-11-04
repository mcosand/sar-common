using System.ComponentModel.DataAnnotations;

namespace Sar.Database.Model.Accounts
{
  public class PasswordResetRequest
  {
    [Required]
    public string Code { get; set; }

    [Required]
    [MinLength(6)]
    public string NewPassword { get; set; }
  }
}
