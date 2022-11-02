using GraphQlDemo.Models;

namespace GraphQlDemo.Types;

public class ManufacturerType : ObjectTypeExtension<Manufacturer>
{
    protected override void Configure(IObjectTypeDescriptor<Manufacturer> descriptor)
    {
        descriptor
            .Ignore(p => p.Id);

        descriptor
            .Field(p => p.HashedId)
            .Name("id");
    }
}