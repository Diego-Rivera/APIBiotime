using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class AccAccprivilege
{
    public int Id { get; set; }

    public DateTime? CreateTime { get; set; }

    public string? CreateUser { get; set; }

    public DateTime? ChangeTime { get; set; }

    public string? ChangeUser { get; set; }

    public short Status { get; set; }

    public short IsGroupTimezone { get; set; }

    public int? Timezone1 { get; set; }

    public int? Timezone2 { get; set; }

    public int? Timezone3 { get; set; }

    public short IsGroupVerifycode { get; set; }

    public int? VerifyMode { get; set; }

    public DateTime? UpdateTime { get; set; }

    public int AreaId { get; set; }

    public int EmployeeId { get; set; }

    public int GroupId { get; set; }

    public virtual PersonnelArea Area { get; set; } = null!;

    public virtual AccAccgroup Group { get; set; } = null!;
}
