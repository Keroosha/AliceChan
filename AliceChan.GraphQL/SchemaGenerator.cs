using System;
using AliceChan.GraphQL.Types;
using AliceChan.GraphQL.Utils.Extensions;
using HotChocolate;
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
        .AddComplexTypesFromAssembly(typeof(SchemaGenerator).Assembly)
        .BindClrType<Guid, StringType>()
        .BindClrType<Uri, StringType>()
        .Create();
    }
  }
}