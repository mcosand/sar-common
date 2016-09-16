using System;

namespace Sar.Database.Model.Members
{
  public class MemberInfo : MemberSummary
  {
    public string First { get; set; }
    public string Middle { get; set; }
    public string Last { get; set; }
    public Gender Gender { get; set; }
    public WacLevel WacLevel { get; set; }
    public DateTime WacLevelDate { get; set; }
    public DateTime? BirthDate { get; set; }
    public bool BackgroundKnown { get; set; }
  }
}
