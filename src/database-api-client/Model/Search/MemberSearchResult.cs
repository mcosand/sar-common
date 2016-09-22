using Sar.Database.Model.Members;

namespace Sar.Database.Model.Search
{
  public class MemberSearchResult : SearchResult
  {
    public MemberSearchResult()
    {
      Type = SearchResultType.Member;
    }
    public MemberSummary Summary { get; set; }
  }
}
