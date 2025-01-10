﻿using System.ComponentModel.DataAnnotations.Schema;

namespace X.EntityFrameworkCore.Extensions.Test.Data;

public abstract class TpcPerson
{
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public long Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}