using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class DjangoCeleryBeatCrontabschedule
{
    public int Id { get; set; }

    public string Minute { get; set; } = null!;

    public string Hour { get; set; } = null!;

    public string DayOfWeek { get; set; } = null!;

    public string DayOfMonth { get; set; } = null!;

    public string MonthOfYear { get; set; } = null!;

    public string Timezone { get; set; } = null!;

    public virtual ICollection<DjangoCeleryBeatPeriodictask1> DjangoCeleryBeatPeriodictask1s { get; } = new List<DjangoCeleryBeatPeriodictask1>();
}
