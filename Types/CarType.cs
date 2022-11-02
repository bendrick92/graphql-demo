using GraphQlDemo.Models;

namespace GraphQlDemo.Types;

public class CarType : ObjectTypeExtension<Car>
{
    protected override void Configure(IObjectTypeDescriptor<Car> descriptor)
    {
        descriptor
            .Ignore(p => p.Id);

        descriptor
            .Field(p => p.HashedId)
            .Name("id");
    }
}