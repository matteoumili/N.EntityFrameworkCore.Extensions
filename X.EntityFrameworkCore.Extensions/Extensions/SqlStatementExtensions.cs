using System.Collections.Generic;
using Shark.EntityFrameworkCore.Extensions.Sql;

namespace Shark.EntityFrameworkCore.Extensions.Extensions;

internal static class SqlStatementExtensions
{
    internal static void WriteInsert(this SqlStatement statement, IEnumerable<string> insertColumns)
    {
            statement.CreatePart(SqlKeyword.Insert, SqlExpression.Columns(insertColumns));
            statement.CreatePart(SqlKeyword.Values, SqlExpression.Columns(insertColumns));
        }
}