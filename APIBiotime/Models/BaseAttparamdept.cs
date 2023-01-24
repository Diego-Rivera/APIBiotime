using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class BaseAttparamdept
{
    public int Id { get; set; }

    public string Rulename { get; set; } = null!;

    public int Deptid { get; set; }

    public string? Operator { get; set; }

    public DateTime? Optime { get; set; }
}
