using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class MobileGpsforemployee
{
    public int Id { get; set; }

    public DateTime? CreateTime { get; set; }

    public string? CreateUser { get; set; }

    public DateTime? ChangeTime { get; set; }

    public string? ChangeUser { get; set; }

    public short Status { get; set; }

    public int Distance { get; set; }

    public DateOnly StartDate { get; set; }

    public DateOnly EndDate { get; set; }

    public int EmployeeId { get; set; }

    public virtual PersonnelEmployee Employee { get; set; } = null!;

    public virtual ICollection<MobileGpsforemployeeLocation> MobileGpsforemployeeLocations { get; } = new List<MobileGpsforemployeeLocation>();
}
