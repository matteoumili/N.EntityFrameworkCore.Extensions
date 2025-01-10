using System;
using System.Linq.Expressions;

namespace X.EntityFrameworkCore.Extensions;

public class BulkFetchOptions<T> : BulkOptions
{
    public Expression<Func<T, object>> IgnoreColumns { get; set; }
    public Expression<Func<T, object>> InputColumns { get; set; }
    public Expression<Func<T, T, bool>> JoinOnCondition { get; set; }
    public BulkFetchOptions()
    {
        //this.ConnectionBehavior = ConnectionBehavior.New;
    }
}