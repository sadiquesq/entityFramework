using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace database.Models;

[Keyless]
[Table("BOOKS")]
public partial class BOOK
{
    [StringLength(50)]
    [Unicode(false)]
    public string? name { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? author { get; set; }

    public int? year { get; set; }
}
