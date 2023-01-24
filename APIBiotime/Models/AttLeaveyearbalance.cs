using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class AttLeaveyearbalance
{
    public int Id { get; set; }

    public DateTime? CreateTime { get; set; }

    public string? CreateUser { get; set; }

    public DateTime? ChangeTime { get; set; }

    public string? ChangeUser { get; set; }

    public short Status { get; set; }

    public int? LeaveType { get; set; }

    public int? Year { get; set; }

    public short? EntitlementDays { get; set; }

    public double? LeaveDay { get; set; }

    public short? PreBalance { get; set; }

    public int EmployeeId { get; set; }

    public int? PayCodeId { get; set; }

    public virtual PersonnelEmployee Employee { get; set; } = null!;

    public virtual AttPaycode? PayCode { get; set; }
}
