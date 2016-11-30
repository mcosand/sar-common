using System;
using System.ComponentModel.DataAnnotations;

namespace Sar.Database.Model.Training
{
  public class TrainingCourse : NameIdPair
  {
    public string FullName { get; set; }
    public string Category { get; set; }
    public NameIdPair Unit { get; set; }
    public int? ValidMonths { get; set; }
    public NameIdPair[] Prerequisites { get; set; }
  }
}