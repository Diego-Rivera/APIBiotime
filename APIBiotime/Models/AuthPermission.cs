using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class AuthPermission
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int ContentTypeId { get; set; }

    public string Codename { get; set; } = null!;

    public virtual ICollection<AuthGroupPermission> AuthGroupPermissions { get; } = new List<AuthGroupPermission>();

    public virtual ICollection<AuthUserUserPermission> AuthUserUserPermissions { get; } = new List<AuthUserUserPermission>();

    public virtual ICollection<GuardianGroupobjectpermission> GuardianGroupobjectpermissions { get; } = new List<GuardianGroupobjectpermission>();

    public virtual ICollection<GuardianUserobjectpermission> GuardianUserobjectpermissions { get; } = new List<GuardianUserobjectpermission>();
}
