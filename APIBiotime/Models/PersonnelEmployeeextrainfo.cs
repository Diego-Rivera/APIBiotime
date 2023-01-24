using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class PersonnelEmployeeextrainfo
{
    public int Id { get; set; }

    public string Value { get; set; } = null!;

    public int EmployeeId { get; set; }

    public virtual PersonnelEmployee Employee { get; set; } = null!;
}
