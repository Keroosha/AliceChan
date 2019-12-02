using System;
using AliceChan.GraphQL.Utils.Interfaces;

namespace AliceChan.GraphQL.Types
{
  public class Thread : IBindAsComplexType
  {
    public Guid Id { get; set; }
    public string Name { get; set; }
  }
}