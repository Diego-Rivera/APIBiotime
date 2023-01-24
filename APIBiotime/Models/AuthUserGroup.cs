using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class AuthUserGroup
{
    public int Id { get; set; }

    public int MyuserId { get; set; }

    public int GroupId { get; set; }

    public virtual AuthGroup Group { get; set; } = null!;

    public virtual AuthUser Myuser { get; set; } = null!;
}
