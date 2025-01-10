using System;
using System.Linq.Expressions;

namespace Shark.EntityFrameworkCore.Extensions;

public class BulkDeleteOptions<T> : BulkOptions
{
    public Expression<Func<T, T, bool>> DeleteOnCondition { get; set; }
}