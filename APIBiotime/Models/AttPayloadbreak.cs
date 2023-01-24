using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class AttPayloadbreak
{
    public string Uuid { get; set; } = null!;

    public DateTime? BreakOut { get; set; }

    public DateTime? BreakIn { get; set; }

    public int? Duration { get; set; }

    public int? Taken { get; set; }

    public int? ActualDuration { get; set; }

    public int? EarlyIn { get; set; }

    public int? LateIn { get; set; }

    public int? Late { get; set; }

    public int? EarlyLeave { get; set; }

    public int? Absent { get; set; }

    public int? WorkTime { get; set; }

    public int? Overtime { get; set; }

    public int? WeekendOt { get; set; }

    public int? HolidayOt { get; set; }
}
