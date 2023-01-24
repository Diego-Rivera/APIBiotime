using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class AttPayloadovertime
{
    public string Uuid { get; set; } = null!;

    public int? NormalWt { get; set; }

    public int? NormalOt { get; set; }

    public int? WeekendOt { get; set; }

    public int? HolidayOt { get; set; }

    public int? OtLv1 { get; set; }

    public int? OtLv2 { get; set; }

    public int? OtLv3 { get; set; }

    public int? TotalOt { get; set; }
}
