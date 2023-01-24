using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class MeetingMeetingtransaction
{
    public int Id { get; set; }

    public string EmpCode { get; set; } = null!;

    public DateTime PunchDatetime { get; set; }

    public DateOnly PunchDate { get; set; }

    public TimeOnly PunchTime { get; set; }

    public string PunchState { get; set; } = null!;

    public short Source { get; set; }

    public DateTime UploadTime { get; set; }

    public int? EmpId { get; set; }

    public int? MeetingId { get; set; }

    public int? TerminalId { get; set; }

    public virtual PersonnelEmployee? Emp { get; set; }

    public virtual MeetingMeetingentity? Meeting { get; set; }

    public virtual IclockTerminal? Terminal { get; set; }
}
