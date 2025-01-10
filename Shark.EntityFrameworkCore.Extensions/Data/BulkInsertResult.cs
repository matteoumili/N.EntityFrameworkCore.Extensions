using System.Collections.Generic;

namespace Shark.EntityFrameworkCore.Extensions;

internal class BulkInsertResult<T>
{
    internal int RowsAffected { get; set; }
    internal Dictionary<long, T> EntityMap { get; set; }
}