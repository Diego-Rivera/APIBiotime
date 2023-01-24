using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class IclockTerminaluploadlog
{
    public int Id { get; set; }

    public string Event { get; set; } = null!;

    public string Content { get; set; } = null!;

    public int UploadCount { get; set; }

    public int ErrorCount { get; set; }

    public DateTime UploadTime { get; set; }

    public int TerminalId { get; set; }

    public virtual IclockTerminal Terminal { get; set; } = null!;
}
