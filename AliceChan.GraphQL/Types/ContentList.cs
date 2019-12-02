using System.Collections.Generic;
using AliceChan.GraphQL.Utils.Interfaces;

namespace AliceChan.GraphQL.Types
{
  public class ContentList : IBindAsComplexType, IListType<Content>
  {
    public IEnumerable<Content> Items { get; set; }
    public PageInfo PageInfo { get; set; }
  }
}