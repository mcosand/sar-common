using Sar.Database.Model.Members;

namespace Sar.Database.Model.Animals
{
  public class Animal : NameIdPair
  {
    public string Type { get; set; }
    public MemberSummary Owner { get; set; }
    public string Status { get; set; }

    public string Comments { get; set; }
    public string IdSuffix { get; set; }
    public string Photo { get; set; }
  }
}
