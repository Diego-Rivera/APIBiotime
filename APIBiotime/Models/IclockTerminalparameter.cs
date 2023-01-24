using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class IclockTerminalparameter
{
    public int Id { get; set; }

    public string? ParamType { get; set; }

    public string ParamName { get; set; } = null!;

    public string ParamValue { get; set; } = null!;

    public int TerminalId { get; set; }

    public virtual IclockTerminal Terminal { get; set; } = null!;
}
