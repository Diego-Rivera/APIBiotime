using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class AttTempschedule
{
    public int Id { get; set; }

    public DateOnly? AttDate { get; set; }

    public DateTime StartTime { get; set; }

    public DateTime EndTime { get; set; }

    public short RuleFlag { get; set; }

    public short WorkType { get; set; }

    public int EmployeeId { get; set; }

    public int? TimeIntervalId { get; set; }

    public virtual PersonnelEmployee Employee { get; set; } = null!;
}
