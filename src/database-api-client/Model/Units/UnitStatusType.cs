using System.ComponentModel.DataAnnotations;

namespace Sar.Database.Model.Units
{
  public class UnitStatusType : NameIdPair
  {
    [Required]
    public NameIdPair Unit { get; set; }

    public bool IsActive { get; set; }
    public bool GetsAccount { get; set; }

    public WacLevel WacLevel { get; set; }
  }
}
