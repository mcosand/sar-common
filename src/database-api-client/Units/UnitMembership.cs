﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sar.Model;

namespace Kcsara.Database.Model.Units
{
  public class UnitMembership
  {
    public Guid Id { get; set; }
    public NameIdPair Unit { get; set; }
    public NameIdPair Member { get; set; }
    public string Status { get; set; }
    public bool IsActive { get; set; }
    public DateTime Start { get; set; }
    public DateTime? End { get; set; }
  }
}
