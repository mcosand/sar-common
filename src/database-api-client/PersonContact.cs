using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kcsara.Database.Model
{
  public class PersonContact
  {
    public Guid Id { get; set; }
    public string Value { get; set; }
    public string Type { get; set; }
    public string SubType { get; set; }
    public int Priority { get; set; }
  }
}
