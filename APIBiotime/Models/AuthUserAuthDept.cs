using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class AuthUserAuthDept
{
    public int Id { get; set; }

    public int MyuserId { get; set; }

    public int DepartmentId { get; set; }

    public virtual PersonnelDepartment Department { get; set; } = null!;

    public virtual AuthUser Myuser { get; set; } = null!;
}
