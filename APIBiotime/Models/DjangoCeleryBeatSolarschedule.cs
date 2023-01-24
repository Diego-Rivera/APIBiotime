using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class DjangoCeleryBeatSolarschedule
{
    public int Id { get; set; }

    public string Event { get; set; } = null!;

    public decimal Latitude { get; set; }

    public decimal Longitude { get; set; }

    public virtual ICollection<DjangoCeleryBeatPeriodictask1> DjangoCeleryBeatPeriodictask1s { get; } = new List<DjangoCeleryBeatPeriodictask1>();
}
