namespace Sar
{
  public class DuplicateItemException : UserErrorException
  {
    public DuplicateItemException(string type, string id) 
      : base("Conflicts with existing object", string.Format("Conflict with {0} {1}", type, id))
    {
    }
  }
}
