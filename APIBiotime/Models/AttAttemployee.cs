using System;
using System.Collections.Generic;
using System.Net;

namespace APIBiotime.Models;

public partial class AttAttemployee
{
    public int Id { get; set; }

    public DateTime? CreateTime { get; set; }

    public string? CreateUser { get; set; }

    public DateTime? ChangeTime { get; set; }

    public string? ChangeUser { get; set; }

    public short Status { get; set; }

    public bool EnableAttendance { get; set; }

    public bool EnableSchedule { get; set; }

    public bool EnableOvertime { get; set; }

    public bool EnableHoliday { get; set; }

    public int EmpId { get; set; }

    public int? GroupId { get; set; }

    public bool EnableCompensatory { get; set; }

    public IPAddress? IpAddress { get; set; }

    public virtual AttAttgroup? Group { get; set; }
}
