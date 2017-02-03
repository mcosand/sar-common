using System;

namespace Sar.Database.Model.Members
{
  public class MemberAddress : Address
  {
    public Guid Id { get; set; }
    public MemberAddressType Type { get; set; }
  }

  public enum MemberAddressType
  {
    /// <summary>Other Address.</summary>
    Other = 0,
    /// <summary>Work Address.</summary>
    Work = 10,
    /// <summary>The address at which the person receives their mail, other than their residence.</summary>
    Mailing = 20,
    /// <summary>The location of the person's residence (where they might get picked up for a mission).</summary>
    Residence = 30
  }
}
