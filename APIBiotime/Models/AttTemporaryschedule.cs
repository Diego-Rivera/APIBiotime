using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class AttTemporaryschedule
{
    public int Id { get; set; }

    public DateTime? CreateTime { get; set; }

    public string? CreateUser { get; set; }

    public DateTime? ChangeTime { get; set; }

    public string? ChangeUser { get; set; }

    public short Status { get; set; }

    public DateOnly AttDate { get; set; }

    public int EmployeeId { get; set; }

    public int? TimeIntervalId { get; set; }

    public virtual PersonnelEmployee Employee { get; set; } = null!;
}
