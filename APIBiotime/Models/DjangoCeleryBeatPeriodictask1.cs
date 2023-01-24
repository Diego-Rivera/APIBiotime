using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class DjangoCeleryBeatPeriodictask1
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Task { get; set; } = null!;

    public string Args { get; set; } = null!;

    public string Kwargs { get; set; } = null!;

    public string? Queue { get; set; }

    public string? Exchange { get; set; }

    public string? RoutingKey { get; set; }

    public DateTime? Expires { get; set; }

    public bool Enabled { get; set; }

    public DateTime? LastRunAt { get; set; }

    public int TotalRunCount { get; set; }

    public DateTime DateChanged { get; set; }

    public string Description { get; set; } = null!;

    public int? CrontabId { get; set; }

    public int? IntervalId { get; set; }

    public int? SolarId { get; set; }

    public bool OneOff { get; set; }

    public DateTime? StartTime { get; set; }

    public int? Priority { get; set; }

    public string Headers { get; set; } = null!;

    public int? ClockedId { get; set; }

    public virtual DjangoCeleryBeatClockedschedule? Clocked { get; set; }

    public virtual DjangoCeleryBeatCrontabschedule? Crontab { get; set; }

    public virtual DjangoCeleryBeatIntervalschedule? Interval { get; set; }

    public virtual DjangoCeleryBeatSolarschedule? Solar { get; set; }
}
