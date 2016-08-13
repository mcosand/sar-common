using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kcsara.Database.Model.Members
{
  public class MemberInfo : MemberSummary
  {
    public string First { get; set; }
    public string Middle { get; set; }
    public string Last { get; set; }
    public Gender Gender { get; set; }
    public WacLevel WacLevel { get; set; }
    public DateTime WacLevelDate { get; set; }
    public DateTime? BirthDate { get; set; }
  }
}
