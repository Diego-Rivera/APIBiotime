using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class EpEptransaction
{
    public int Id { get; set; }

    public DateTime? CreateTime { get; set; }

    public string? CreateUser { get; set; }

    public DateTime? ChangeTime { get; set; }

    public string? ChangeUser { get; set; }

    public short Status { get; set; }

    public string Area { get; set; } = null!;

    public DateTime? CheckDatetime { get; set; }

    public DateOnly CheckDate { get; set; }

    public TimeOnly CheckTime { get; set; }

    public decimal Temperature { get; set; }

    public int IsMask { get; set; }

    public DateTime UploadTime { get; set; }

    public short Source { get; set; }

    public string? TerminalSn { get; set; }

    public int? EmpId { get; set; }

    public int? TerminalId { get; set; }

    public string EmpCode { get; set; } = null!;

    public virtual PersonnelEmployee? Emp { get; set; }

    public virtual IclockTerminal? Terminal { get; set; }
}
