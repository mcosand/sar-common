using System;
using System.ComponentModel.DataAnnotations;

namespace Sar.Database.Model.Accounts
{
  public class Account : IId
  {
    public Guid Id { get; set; }
    public string Username { get; set; }

    [Required]
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Name { get { return $"{FirstName} {LastName}"; } }

    [Required]
    [EmailAddress]
    public string Email { get; set; }

    public DateTime? LastLogin { get; set; }
    public string LockReason { get; set; }
    public DateTime? LockDate { get; set; }

    public Guid? MemberId { get; set; }
    public virtual bool HasExternalLogins { get; set; }
  }
}