using System;

namespace Shark.EntityFrameworkCore.Extensions.Test.Data;

public class TptCustomer : TptPerson
{
    public string Email { get; set; }
    public string Phone { get; set; }
    public DateTime AddedDate { get; set; }
}