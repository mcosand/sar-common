using System;
using System.ComponentModel.DataAnnotations;

namespace Sar.Database.Model
{
  public class NameIdPair : IId
  {
    public Guid Id { get; set; }

    [Required]
    [MaxLength(20, ErrorMessage = "Too long")]
    public string Name { get; set; }
  }
}
