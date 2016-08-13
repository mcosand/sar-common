/*
 * Copyright 2016 Matthew Cosand
 */
using System;
using System.Collections.Generic;

namespace Sar.Model.Auth
{
  public class UserInfo
  {
    public UserInfo()
    {
      Roles = new List<string>();
      Units = new List<NameIdPair>();
      Scopes = new List<string>();
    }
    public List<string> Roles { get; set; }

    public Guid? MemberId { get; set; }

    public List<NameIdPair> Units { get; set; }

    public List<string> Scopes { get; set; }
  }
}
