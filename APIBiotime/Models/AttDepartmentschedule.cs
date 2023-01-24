using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class AttDepartmentschedule
{
    public int Id { get; set; }

    public DateTime? CreateTime { get; set; }

    public string? CreateUser { get; set; }

    public DateTime? ChangeTime { get; set; }

    public string? ChangeUser { get; set; }

    public short Status { get; set; }

    public DateOnly StartDate { get; set; }

    public DateOnly EndDate { get; set; }

    public int DepartmentId { get; set; }

    public int ShiftId { get; set; }

    public virtual PersonnelDepartment Department { get; set; } = null!;

    public virtual AttAttshift Shift { get; set; } = null!;
}
