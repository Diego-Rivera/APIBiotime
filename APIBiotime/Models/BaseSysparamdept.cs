using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class BaseSysparamdept
{
    public int Id { get; set; }

    public string RuleName { get; set; } = null!;

    public int DeptId { get; set; }

    public string? Operator { get; set; }

    public DateTime? OpTime { get; set; }
}
