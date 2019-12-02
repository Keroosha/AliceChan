using System;
using System.Collections.Generic;
using AliceChan.GraphQL.Utils.Interfaces;
using HotChocolate;

namespace AliceChan.GraphQL.Types
{
  public class Query : IBindAsComplexType
  {
    public IEnumerable<Board> boards(IEnumerable<Guid> guids) => new []
    {
      new Board { Id = new Guid(), Name = "test" },
      new Board { Id = new Guid(), Name = "test1" }
    };
  }
}