using System;

namespace X.EntityFrameworkCore.Extensions.Test.Data;

public class TpcCustomer : TpcPerson
{
    public string Email { get; set; }
    public string Phone { get; set; }
    public DateTime AddedDate { get; set; }
}