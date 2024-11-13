using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace database.Models;

[Keyless]
[Table("EMPLOYEE")]
public partial class EMPLOYEE
{
    public int? id { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? name { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? department { get; set; }

    public int? salary { get; set; }
}
