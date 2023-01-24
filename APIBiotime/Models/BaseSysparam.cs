using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class BaseSysparam
{
    public int Id { get; set; }

    public string ParaName { get; set; } = null!;

    public string? ParaType { get; set; }

    public string? ParaValue { get; set; }
}
