using System;
using AliceChan.GraphQL.Utils.Interfaces;
using AliceChan.Shared;

namespace AliceChan.GraphQL.Types
{

  
  public class Content : IBindAsComplexType
  {
    public Guid Id { get; set; }
    public ContentType ContentType { get; set; }
    public Uri Uri { get; set; }
  }
}