using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class AttAttschedule
{
    public int Id { get; set; }

    public DateOnly StartDate { get; set; }

    public DateOnly EndDate { get; set; }

    public int EmployeeId { get; set; }

    public int ShiftId { get; set; }

    public virtual PersonnelEmployee Employee { get; set; } = null!;

    public virtual AttAttshift Shift { get; set; } = null!;
}
