using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class AccAcctimezone
{
    public int Id { get; set; }

    public DateTime? CreateTime { get; set; }

    public string? CreateUser { get; set; }

    public DateTime? ChangeTime { get; set; }

    public string? ChangeUser { get; set; }

    public short Status { get; set; }

    public int TimezoneNo { get; set; }

    public string TimezoneName { get; set; } = null!;

    public TimeOnly SunStart { get; set; }

    public TimeOnly SunEnd { get; set; }

    public short? SunOn { get; set; }

    public TimeOnly MonStart { get; set; }

    public TimeOnly MonEnd { get; set; }

    public short? MonOn { get; set; }

    public TimeOnly TueStart { get; set; }

    public TimeOnly TueEnd { get; set; }

    public short? TueOn { get; set; }

    public TimeOnly WedStart { get; set; }

    public TimeOnly WedEnd { get; set; }

    public short? WedOn { get; set; }

    public TimeOnly ThuStart { get; set; }

    public TimeOnly ThuEnd { get; set; }

    public short? ThuOn { get; set; }

    public TimeOnly FriStart { get; set; }

    public TimeOnly FriEnd { get; set; }

    public short? FriOn { get; set; }

    public TimeOnly SatStart { get; set; }

    public TimeOnly SatEnd { get; set; }

    public short? SatOn { get; set; }

    public string? Remark { get; set; }

    public DateTime? UpdateTime { get; set; }

    public int AreaId { get; set; }

    public virtual ICollection<AccAccholiday> AccAccholidays { get; } = new List<AccAccholiday>();

    public virtual PersonnelArea Area { get; set; } = null!;
}
