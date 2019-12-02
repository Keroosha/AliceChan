using System;
using AliceChan.GraphQL.Utils.Interfaces;
using HotChocolate;
using HotChocolate.Types;

namespace AliceChan.GraphQL.Types
{
  public class Board : IBindAsComplexType
  {
    public Guid Id { get; set; }
    public string Name { get; set; }
  }
}