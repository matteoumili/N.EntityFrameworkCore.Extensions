﻿using System;
using System.Linq.Expressions;

namespace X.EntityFrameworkCore.Extensions;

public class BulkUpdateOptions<T> : BulkOptions
{
    public Expression<Func<T, object>> InputColumns { get; set; }
    public Expression<Func<T, object>> IgnoreColumns { get; set; }
    public Expression<Func<T, T, bool>> UpdateOnCondition { get; set; }
}