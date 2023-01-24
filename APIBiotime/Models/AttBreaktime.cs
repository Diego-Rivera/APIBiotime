using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class AttBreaktime
{
    public int Id { get; set; }

    public string Alias { get; set; } = null!;

    public TimeOnly PeriodStart { get; set; }

    public int Duration { get; set; }

    public int EndMargin { get; set; }

    public short FuncKey { get; set; }

    public short AvailableIntervalType { get; set; }

    public int AvailableInterval { get; set; }

    public short MultiplePunch { get; set; }

    public short CalcType { get; set; }

    public int? MinimumDuration { get; set; }

    public short EarlyIn { get; set; }

    public short LateIn { get; set; }

    public bool ProfitRule { get; set; }

    public int MinEarlyIn { get; set; }

    public bool LossRule { get; set; }

    public int MinLateIn { get; set; }

    public int? LossCodeId { get; set; }

    public int? ProfitCodeId { get; set; }

    public virtual ICollection<AttTimeintervalBreakTime> AttTimeintervalBreakTimes { get; } = new List<AttTimeintervalBreakTime>();

    public virtual AttPaycode? LossCode { get; set; }

    public virtual AttPaycode? ProfitCode { get; set; }
}
