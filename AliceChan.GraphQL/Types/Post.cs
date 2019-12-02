using System;
using AliceChan.GraphQL.Utils.Interfaces;

namespace AliceChan.GraphQL.Types
{
  public class Post : IBindAsComplexType
  {
    public Guid Id { get; set; }
    public long PostNumber { get; set; }
  }
}