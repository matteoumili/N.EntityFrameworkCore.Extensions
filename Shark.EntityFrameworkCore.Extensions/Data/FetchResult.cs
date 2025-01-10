﻿using System.Collections.Generic;

namespace Shark.EntityFrameworkCore.Extensions;

public class FetchResult<T>
{
    public List<T> Results { get; set; }
    public int Batch { get; set; }
}