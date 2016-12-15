using System;
using Sar.Database.Model.Members;

namespace Sar.Database.Model.Animals
{
  public class AnimalOwner : IId
  {
    public Guid Id { get; set; }
    public MemberSummary Member { get; set; }
    public NameIdPair Animal { get; set; }
    public DateTimeOffset Starting { get; set; }
    public DateTimeOffset? Ending { get; set; }
    public bool IsPrimary { get; set; }
  }
}
