using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class AccAccholiday
{
    public int Id { get; set; }

    public DateTime? CreateTime { get; set; }

    public string? CreateUser { get; set; }

    public DateTime? ChangeTime { get; set; }

    public string? ChangeUser { get; set; }

    public short Status { get; set; }

    public DateTime? UpdateTime { get; set; }

    public int AreaId { get; set; }

    public int HolidayId { get; set; }

    public int TimezoneId { get; set; }

    public virtual PersonnelArea Area { get; set; } = null!;

    public virtual AttHoliday Holiday { get; set; } = null!;

    public virtual AccAcctimezone Timezone { get; set; } = null!;
}
