using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class DjangoCeleryBeatIntervalschedule
{
    public int Id { get; set; }

    public int Every { get; set; }

    public string Period { get; set; } = null!;

    public virtual ICollection<DjangoCeleryBeatPeriodictask1> DjangoCeleryBeatPeriodictask1s { get; } = new List<DjangoCeleryBeatPeriodictask1>();
}
