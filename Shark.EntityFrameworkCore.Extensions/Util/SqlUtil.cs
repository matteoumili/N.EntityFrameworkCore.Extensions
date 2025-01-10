using System.Collections.Generic;

namespace Shark.EntityFrameworkCore.Extensions;

internal static class SqlUtil
{
    internal static string ConvertToColumnString(IEnumerable<string> columnNames)
    {
        return string.Join(",", columnNames);
    }
}