using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace database.Models;

[Table("Books1")]
public partial class Books1
{
    [Key]
    public int Id { get; set; }

    public string name { get; set; } = null!;

    public string author { get; set; } = null!;

    public int year { get; set; }
}
