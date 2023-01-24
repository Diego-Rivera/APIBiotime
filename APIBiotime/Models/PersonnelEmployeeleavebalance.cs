using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class PersonnelEmployeeleavebalance
{
    public int Id { get; set; }

    public DateTime? CreateTime { get; set; }

    public string? CreateUser { get; set; }

    public DateTime? ChangeTime { get; set; }

    public string? ChangeUser { get; set; }

    public short Status { get; set; }

    public int LeaveBalance { get; set; }

    public int EmployeeId { get; set; }

    public int LeaveTypeId { get; set; }

    public virtual PersonnelEmployee Employee { get; set; } = null!;

    public virtual AttPaycode LeaveType { get; set; } = null!;
}
