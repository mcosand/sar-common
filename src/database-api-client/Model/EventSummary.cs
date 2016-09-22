using System;

namespace Sar.Database.Model
{
  public class EventSummary
  {
    public Guid Id { get; set; }

    public string Name { get; set; }
    public string StateNumber { get; set; }
    public string Location { get; set; }


    public DateTimeOffset Start { get; set; }
    public DateTimeOffset? Stop { get; set; }
  }
}
