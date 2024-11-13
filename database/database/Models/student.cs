using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace database.Models;

public partial class student
{
    [Key]
    public int StudentId { get; set; }

    public string Name { get; set; } = null!;

    public int age { get; set; }
}
