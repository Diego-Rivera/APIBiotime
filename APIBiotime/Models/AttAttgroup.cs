using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class AttAttgroup
{
    public int Id { get; set; }

    public DateTime? CreateTime { get; set; }

    public string? CreateUser { get; set; }

    public DateTime? ChangeTime { get; set; }

    public string? ChangeUser { get; set; }

    public short Status { get; set; }

    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public virtual ICollection<AttAttemployee> AttAttemployees { get; } = new List<AttAttemployee>();

    public virtual ICollection<AttGrouppolicy> AttGrouppolicies { get; } = new List<AttGrouppolicy>();

    public virtual ICollection<AttGroupschedule> AttGroupschedules { get; } = new List<AttGroupschedule>();

    public virtual ICollection<AttHoliday> AttHolidays { get; } = new List<AttHoliday>();
}
