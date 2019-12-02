using HotChocolate;

namespace AliceChan.GraphQL
{
  internal static class StubResolvers
  {
    static ISchemaBuilder AddStubResolvers (this ISchemaBuilder schemaBuilder)
    {
      return schemaBuilder;
    }
  }
}