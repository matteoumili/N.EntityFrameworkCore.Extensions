using System.Collections.Generic;

namespace X.EntityFrameworkCore.Extensions;

public class FetchResult<T>
{
    public List<T> Results { get; set; }
    public int Batch { get; set; }
}