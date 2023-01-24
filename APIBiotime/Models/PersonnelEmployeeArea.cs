using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class PersonnelEmployeeArea
{
    public int Id { get; set; }

    public int EmployeeId { get; set; }

    public int AreaId { get; set; }

    public virtual PersonnelArea Area { get; set; } = null!;
}
