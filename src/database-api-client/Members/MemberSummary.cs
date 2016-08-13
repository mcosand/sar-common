using System;
using Sar.Model;

namespace Kcsara.Database.Model.Members
{
  public class MemberSummary : NameIdPair
  {
    public string WorkerNumber { get; set; }

    public string Photo { get; set; }

    public NameIdPair[] Units { get; set; }
  }
}
