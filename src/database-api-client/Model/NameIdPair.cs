using System;
using System.ComponentModel.DataAnnotations;

namespace Sar.Database.Model
{
  public class NameIdPair : IId
  {
    public Guid Id { get; set; }

    [Required]
    public string Name { get; set; }
  }
}
