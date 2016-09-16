using System;

namespace Sar.Database.Model.Units
{
  public class UnitStatusType
  {
    public Guid Id { get; set; }
    public NameIdPair Unit { get; set; }
    public string Name { get; set; }
    public bool IsActive { get; set; }
    public bool GetsAccount { get; set; }
  }
}
