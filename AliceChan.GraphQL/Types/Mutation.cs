using AliceChan.GraphQL.Utils.Interfaces;

namespace AliceChan.GraphQL.Types
{
  public class Mutation : IBindAsComplexType
  {
    public bool Test() => true;
  }
}