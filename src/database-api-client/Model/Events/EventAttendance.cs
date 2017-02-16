using System;

namespace Sar.Database.Model
{
  public class EventAttendance : IId
  {
    public Guid Id { get; set; }
    public EventSummary Event { get; set; }
    public int Miles { get; set; }
    public double Hours { get; set; }
  }

  public class GroupEventAttendance : EventAttendance
  {
    public int Persons { get; set; }
  }
}
