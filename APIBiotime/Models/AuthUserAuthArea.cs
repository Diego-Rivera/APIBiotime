using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class AuthUserAuthArea
{
    public int Id { get; set; }

    public int MyuserId { get; set; }

    public int AreaId { get; set; }

    public virtual PersonnelArea Area { get; set; } = null!;

    public virtual AuthUser Myuser { get; set; } = null!;
}
