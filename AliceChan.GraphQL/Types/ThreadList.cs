using System.Collections.Generic;
using AliceChan.GraphQL.Utils.Interfaces;

namespace AliceChan.GraphQL.Types
{
  public class ThreadList : IBindAsComplexType, IListType<Thread>
  {
    public IEnumerable<Thread> Items { get; set; }
    public PageInfo PageInfo { get; set; }
  }
}