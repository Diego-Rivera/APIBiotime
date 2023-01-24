using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class IclockTerminallog
{
    public int Id { get; set; }

    public short? TerminalTz { get; set; }

    public string? Admin { get; set; }

    public short? ActionName { get; set; }

    public DateTime? ActionTime { get; set; }

    public string? Object { get; set; }

    public int? Param1 { get; set; }

    public int? Param2 { get; set; }

    public int? Param3 { get; set; }

    public DateTime? UploadTime { get; set; }

    public int TerminalId { get; set; }

    public virtual IclockTerminal Terminal { get; set; } = null!;
}
