using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class AttPayloadeffectpunch
{
    public Guid Id { get; set; }

    public DateOnly AttDate { get; set; }

    public DateTime PunchDatetime { get; set; }

    public DateOnly PunchDate { get; set; }

    public TimeOnly PunchTime { get; set; }

    public short Week { get; set; }

    public short Weekday { get; set; }

    public string WorkCode { get; set; } = null!;

    public string PunchState { get; set; } = null!;

    public string AdjustState { get; set; } = null!;

    public int EmpId { get; set; }

    public Guid? TimeCardId { get; set; }

    public int TransId { get; set; }

    public virtual PersonnelEmployee Emp { get; set; } = null!;

    public virtual IclockTransaction Trans { get; set; } = null!;
}
