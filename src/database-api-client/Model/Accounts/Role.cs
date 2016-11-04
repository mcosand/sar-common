using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sar.Database.Model.Accounts
{
  public class Role
  {
    public Role()
    {
      Includes = new List<Role>();
    }

    public string Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public List<Role> Includes { get; set; }
  }
}
