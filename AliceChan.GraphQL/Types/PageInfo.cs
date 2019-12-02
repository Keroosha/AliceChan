using System;
using AliceChan.GraphQL.Utils.Interfaces;

namespace AliceChan.GraphQL.Types
{
  public class PageInfo : IBindAsComplexType
  {
    public bool HasMore { get; set; } 
    public Guid Cursor { get; set; }
    public Guid LastCursor { get; set; }
  }
}