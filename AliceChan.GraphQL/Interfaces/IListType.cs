using System.Collections.Generic;
using AliceChan.GraphQL.Types;

namespace AliceChan.GraphQL
{
  public interface IListType<T>
  {
    IEnumerable<T> Items { get; set; }
    PageInfo PageInfo { get; set; }
  }
}