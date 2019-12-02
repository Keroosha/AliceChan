using System;
using System.Linq;
using System.Reflection;
using AliceChan.GraphQL.Utils.Interfaces;
using HotChocolate;
using HotChocolate.Configuration.Bindings;
using HotChocolate.Types;

namespace AliceChan.GraphQL.Utils.Extensions
{
  public static class SchemaBuilderExtensions
  {
    public static ISchemaBuilder AddComplexTypesFromAssembly(this ISchemaBuilder schemaBuilder, Assembly assembly)
    {
      bool MarkedTypes(Type x) =>
        x.IsClass && x.GetInterfaces().Contains(typeof(IBindAsComplexType));

      IBindingInfo BindTypes(Type x) =>
        ComplexTypeBindingBuilder.New()
          .SetFieldBinding(BindingBehavior.Implicit)
          .SetType(x)
          .Create();

      void Register(IBindingInfo x) => schemaBuilder.AddBinding(x);

      assembly
        .GetTypes()
        .Where(MarkedTypes)
        .Select(BindTypes)
        .ToList()
        .ForEach(Register);

      return schemaBuilder;
    }
  }
}