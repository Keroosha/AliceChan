using System;
using AliceChan.GraphQL.Types;
using HotChocolate;
using HotChocolate.Execution;
using HotChocolate.Types;

namespace AliceChan.GraphQL
{
  public class SchemaGenerator
  {
    public ISchema Schema { get; }

    public SchemaGenerator(IServiceProvider serviceProvider)
    {
      Schema = new SchemaBuilder()
        .AddServices(serviceProvider)
        .AddDocumentFromFile("typedef.graphql")
        .BindComplexType<Query>()
        .BindComplexType<Mutation>()
        .BindClrType<Guid, StringType>()
        .Create();
    }
  }
}