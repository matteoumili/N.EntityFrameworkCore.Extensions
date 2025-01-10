using Microsoft.EntityFrameworkCore.Metadata;

namespace Shark.EntityFrameworkCore.Extensions.Extensions;

public static class IPropertyExtensions
{
    public static IEntityType GetDeclaringEntityType(this IProperty property)
    {
            return property.DeclaringType as IEntityType;
        }
}