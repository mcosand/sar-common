using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sar.Database.Model
{
  public static class PermissionWrapper
  {
    public static ItemPermissionWrapper<T> Create<T>(T item, bool u, bool d) where T : class
    {
      return new ItemPermissionWrapper<T>
      {
        Item = item,
        U = u,
        D = d
      };
    }

  }


  public class ListPermissionWrapper<T> where T : class
  {
    public IEnumerable<ItemPermissionWrapper<T>> Items { get; set; } = new List<ItemPermissionWrapper<T>>();
    public bool C { get; set; } = false;
  }

  public interface IItemPermissionWrapper
  {
    object Item { get; }
    bool U { get; set; }
    bool D { get; set; }
    Dictionary<string, bool> More { get; set; }
  }

  public class ItemPermissionWrapper<T> : IItemPermissionWrapper where T : class
  {
    public T Item { get; set; }
    public bool U { get; set; }
    public bool D { get; set; }

    public Dictionary<string, bool> More { get; set; } = new Dictionary<string, bool>();

    object IItemPermissionWrapper.Item { get { return Item; } }
  }
}
