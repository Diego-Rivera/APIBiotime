using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class AttDeptattrule
{
    public int Id { get; set; }

    public string Alias { get; set; } = null!;

    public string? Rule { get; set; }

    public int DepartmentId { get; set; }

    public virtual PersonnelDepartment Department { get; set; } = null!;
}
