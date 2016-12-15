using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sar.Database.Model.Members;

namespace Sar.Database.Model
{
  public class AttendanceStatistics<T> where T : NameIdPair
  {
    public AttendanceStatisticsPart Total { get; set; }
    public AttendanceStatisticsPart Recent { get; set; }

    public DateTimeOffset? Earliest { get; set; }

    public T Responder { get; set; }
  }

  public class AttendanceStatisticsPart
  {
    public int Count { get; set; }
    public double Hours { get; set; }
    public int Miles { get; set; }
  }
}
