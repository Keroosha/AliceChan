using System;
using System.Collections.Generic;

namespace AliceChan.GraphQL.Types
{
  public class Query
  {
    public IEnumerable<dynamic> boards => new []
    {
      new { id = new Guid(), name = "test" },
      new { id = new Guid(), name = "test1" }
    };
  }
}