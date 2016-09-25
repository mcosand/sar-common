using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sar.Database.Model
{
  public static class PermissionWrapper
  {
    public static ItemPermissionWrapper<T> Create<T>(T item, int u, int d) where T : class
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
    public int C { get; set; } = 0;
  }

  public interface IItemPermissionWrapper
  {
    object Item { get; }
    int U { get; set; }
    int D { get; set; }
  }

  public class ItemPermissionWrapper<T> : IItemPermissionWrapper where T : class
  {
    public T Item { get; set; }
    public int U { get; set; }
    public int D { get; set; }
    object IItemPermissionWrapper.Item { get { return Item; } }
  }
}
