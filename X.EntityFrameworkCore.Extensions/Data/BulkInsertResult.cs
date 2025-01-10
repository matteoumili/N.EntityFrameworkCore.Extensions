using System.Collections.Generic;

namespace X.EntityFrameworkCore.Extensions;

internal class BulkInsertResult<T>
{
    internal int RowsAffected { get; set; }
    internal Dictionary<long, T> EntityMap { get; set; }
}