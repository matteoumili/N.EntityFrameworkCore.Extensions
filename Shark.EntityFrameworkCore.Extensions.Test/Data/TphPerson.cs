using System.ComponentModel.DataAnnotations.Schema;

namespace Shark.EntityFrameworkCore.Extensions.Test.Data;

[Table("TphPeople")]
public abstract class TphPerson
{
    public long Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}