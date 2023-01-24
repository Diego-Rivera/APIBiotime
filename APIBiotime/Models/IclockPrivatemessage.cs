using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class IclockPrivatemessage
{
    public int Id { get; set; }

    public DateTime? CreateTime { get; set; }

    public string? CreateUser { get; set; }

    public DateTime? ChangeTime { get; set; }

    public string? ChangeUser { get; set; }

    public short Status { get; set; }

    public DateTime? LastSend { get; set; }

    public int EmployeeId { get; set; }

    public int? MessageId { get; set; }

    public virtual PersonnelEmployee Employee { get; set; } = null!;

    public virtual IclockShortmessage? Message { get; set; }
}
