using System;
using System.ComponentModel.DataAnnotations;

namespace Sar.Database.Model.Training
{
  public class TrainingRecord
  {
    public Guid Id { get; set; }

    [Required]
    public NameIdPair Member { get; set; }

    [Required]
    public NameIdPair Course { get; set; }

    public DateTimeOffset Completed { get; set; }

    public DateTimeOffset? Expires { get; set; }

    public string ExpirySrc { get; set; }

    public string Source { get; set; }

    public Guid ReferenceId { get; set; }

    public string Comments { get; set; }
  }
}