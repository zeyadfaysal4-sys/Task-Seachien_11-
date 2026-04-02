using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Task_Seachien_11_.Models;

[Keyless]
[Table("prices", Schema = "sales")]
public partial class Price
{
    [Column("id")]
    public int? Id { get; set; }

    [Column("price")]
    public int? Price1 { get; set; }

    [Column("name")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Name { get; set; }
}
