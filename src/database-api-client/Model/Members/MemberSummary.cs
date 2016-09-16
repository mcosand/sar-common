namespace Sar.Database.Model.Members
{
  public class MemberSummary : NameIdPair
  {
    public string WorkerNumber { get; set; }

    public string Photo { get; set; }

    public UnitMembershipSummary[] Units { get; set; }
  }

  public class UnitMembershipSummary
  {
    public NameIdPair Unit { get; set; }
    public string Status { get; set; }
  }
}
