using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class PersonnelAssignareaemployee
{
    public int Id { get; set; }

    public DateTime AssignedTime { get; set; }

    public int AreaId { get; set; }

    public int EmployeeId { get; set; }

    public virtual PersonnelArea Area { get; set; } = null!;

    public virtual PersonnelEmployee Employee { get; set; } = null!;
}
