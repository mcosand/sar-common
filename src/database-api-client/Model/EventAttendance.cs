using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sar.Database.Model
{
  public class EventAttendance
  {
    public EventSummary Event { get; set; }
    public int Miles { get; set; }
    public double Hours { get; set; }
  }

  public class GroupEventAttendance : EventAttendance
  {
    public int Persons { get; set; }
  }
}
