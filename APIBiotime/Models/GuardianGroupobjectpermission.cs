using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class GuardianGroupobjectpermission
{
    public int Id { get; set; }

    public string ObjectPk { get; set; } = null!;

    public int ContentTypeId { get; set; }

    public int GroupId { get; set; }

    public int PermissionId { get; set; }

    public virtual DjangoContentType ContentType { get; set; } = null!;

    public virtual AuthGroup Group { get; set; } = null!;

    public virtual AuthPermission Permission { get; set; } = null!;
}
