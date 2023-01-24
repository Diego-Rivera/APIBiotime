using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class IclockErrorcommandlog
{
    public int Id { get; set; }

    public string? ErrorCode { get; set; }

    public string? ErrorMsg { get; set; }

    public string? DataOrigin { get; set; }

    public string? Cmd { get; set; }

    public string? Additional { get; set; }

    public DateTime UploadTime { get; set; }

    public int TerminalId { get; set; }

    public virtual IclockTerminal Terminal { get; set; } = null!;
}
