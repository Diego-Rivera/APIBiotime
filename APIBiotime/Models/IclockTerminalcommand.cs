using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class IclockTerminalcommand
{
    public int Id { get; set; }

    public string Content { get; set; } = null!;

    public DateTime CommitTime { get; set; }

    public DateTime? TransferTime { get; set; }

    public DateTime? ReturnTime { get; set; }

    public int? ReturnValue { get; set; }

    public int? Package { get; set; }

    public int TerminalId { get; set; }

    public virtual IclockTerminal Terminal { get; set; } = null!;
}
