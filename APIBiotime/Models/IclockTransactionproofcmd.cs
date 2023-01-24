using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class IclockTransactionproofcmd
{
    public int Id { get; set; }

    public DateTime ActionTime { get; set; }

    public DateTime StartTime { get; set; }

    public DateTime EndTime { get; set; }

    public int? TerminalCount { get; set; }

    public int? ServerCount { get; set; }

    public short? Flag { get; set; }

    public int? ReservedInit { get; set; }

    public double? ReservedFloat { get; set; }

    public string? ReservedChar { get; set; }

    public int TerminalId { get; set; }

    public virtual IclockTerminal Terminal { get; set; } = null!;
}
