using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class AuthGroup
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<AuthGroupPermission> AuthGroupPermissions { get; } = new List<AuthGroupPermission>();

    public virtual ICollection<AuthUserGroup> AuthUserGroups { get; } = new List<AuthUserGroup>();

    public virtual ICollection<GuardianGroupobjectpermission> GuardianGroupobjectpermissions { get; } = new List<GuardianGroupobjectpermission>();
}
