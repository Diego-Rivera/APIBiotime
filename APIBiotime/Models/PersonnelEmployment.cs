using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class PersonnelEmployment
{
    public int Id { get; set; }

    public short EmploymentType { get; set; }

    public DateOnly StartDate { get; set; }

    public DateOnly EndDate { get; set; }

    public DateTime? ActiveTime { get; set; }

    public DateTime? InactiveTime { get; set; }

    public int EmployeeId { get; set; }

    public virtual PersonnelEmployee Employee { get; set; } = null!;
}
