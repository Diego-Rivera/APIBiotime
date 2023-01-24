using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class VisitorVisitortransaction
{
    public int Id { get; set; }

    public DateTime? CreateTime { get; set; }

    public string? CreateUser { get; set; }

    public DateTime? ChangeTime { get; set; }

    public string? ChangeUser { get; set; }

    public short Status { get; set; }

    public string VisitorCode { get; set; } = null!;

    public string Area { get; set; } = null!;

    public DateTime? PunchTime { get; set; }

    public string PunchState { get; set; } = null!;

    public int VerifyType { get; set; }

    public decimal Temperature { get; set; }

    public int IsMask { get; set; }

    public DateTime UploadTime { get; set; }

    public short Source { get; set; }

    public string? TerminalSn { get; set; }

    public string? TerminalAlias { get; set; }

    public int? TerminalId { get; set; }

    public int? VisitorId { get; set; }

    public virtual IclockTerminal? Terminal { get; set; }

    public virtual VisitorVisitor? Visitor { get; set; }
}
