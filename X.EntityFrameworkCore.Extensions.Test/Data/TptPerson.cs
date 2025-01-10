using System.ComponentModel.DataAnnotations.Schema;

namespace Shark.EntityFrameworkCore.Extensions.Test.Data;

public class TptPerson
{
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public long Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}