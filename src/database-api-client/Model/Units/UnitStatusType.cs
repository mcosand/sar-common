using System;
using System.ComponentModel.DataAnnotations;

namespace Sar.Database.Model.Units
{
  public class UnitStatusType
  {
    public Guid Id { get; set; }

    [Required]
    public NameIdPair Unit { get; set; }

    [Required]
    [MaxLength(3, ErrorMessage = "Too long")]
    public string Name { get; set; }
    public bool IsActive { get; set; }
    public bool GetsAccount { get; set; }

    public WacLevel WacLevel { get; set; }
  }
}
