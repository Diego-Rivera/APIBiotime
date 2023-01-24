using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class DjangoCeleryBeatClockedschedule
{
    public int Id { get; set; }

    public DateTime ClockedTime { get; set; }

    public bool Enabled { get; set; }

    public virtual ICollection<DjangoCeleryBeatPeriodictask1> DjangoCeleryBeatPeriodictask1s { get; } = new List<DjangoCeleryBeatPeriodictask1>();
}
