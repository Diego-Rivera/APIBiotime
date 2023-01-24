using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class AttShiftdetail
{
    public int Id { get; set; }

    public TimeOnly InTime { get; set; }

    public TimeOnly OutTime { get; set; }

    public int DayIndex { get; set; }

    public int ShiftId { get; set; }

    public int TimeIntervalId { get; set; }

    public virtual AttAttshift Shift { get; set; } = null!;

    public virtual AttTimeinterval TimeInterval { get; set; } = null!;
}
