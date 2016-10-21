using System;
using Sar.Database.Model.Members;

namespace Sar.Database.Model.Units
{
  public class UnitMembership : IId
  {
    public Guid Id { get; set; }
    public NameIdPair Unit { get; set; }
    public MemberSummary Member { get; set; }
    public string Status { get; set; }
    public bool IsActive { get; set; }
    public DateTime Start { get; set; }
    public DateTime? End { get; set; }
  }
}
