using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class GuardianUserobjectpermission
{
    public int Id { get; set; }

    public string ObjectPk { get; set; } = null!;

    public int ContentTypeId { get; set; }

    public int PermissionId { get; set; }

    public int UserId { get; set; }

    public virtual DjangoContentType ContentType { get; set; } = null!;

    public virtual AuthPermission Permission { get; set; } = null!;

    public virtual AuthUser User { get; set; } = null!;
}
