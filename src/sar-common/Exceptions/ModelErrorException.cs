using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sar
{
  public class ModelErrorException : Exception
  {
    public ModelErrorException(string property, string error) : this(new Dictionary<string, IEnumerable<string>> { { property, new[] { error } } }, null)
    {
    }

    public ModelErrorException(Dictionary<string, IEnumerable<string>> propertyErrors, string generalError) : base()
    {
      PropertyErrors = propertyErrors;
      Error = generalError;
    }

    public string Error { get; private set; }
    public Dictionary<string, IEnumerable<string>> PropertyErrors { get; private set; }
  }
}
