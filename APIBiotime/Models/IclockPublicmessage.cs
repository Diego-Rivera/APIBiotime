using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class IclockPublicmessage
{
    public int Id { get; set; }

    public DateTime? CreateTime { get; set; }

    public string? CreateUser { get; set; }

    public DateTime? ChangeTime { get; set; }

    public string? ChangeUser { get; set; }

    public short Status { get; set; }

    public DateTime? LastSend { get; set; }

    public int? MessageId { get; set; }

    public int TerminalId { get; set; }

    public virtual IclockShortmessage? Message { get; set; }

    public virtual IclockTerminal Terminal { get; set; } = null!;
}
