using System;
using System.Collections.Generic;
using System.Net;

namespace APIBiotime.Models;

public partial class BaseAdminlog
{
    public int Id { get; set; }

    public string Action { get; set; } = null!;

    public string? Targets { get; set; }

    public string? TargetsRepr { get; set; }

    public short ActionStatus { get; set; }

    public string? Description { get; set; }

    public IPAddress? IpAddress { get; set; }

    public bool CanRoutable { get; set; }

    public DateTime OpTime { get; set; }

    public int? ContentTypeId { get; set; }

    public int UserId { get; set; }

    public virtual DjangoContentType? ContentType { get; set; }

    public virtual AuthUser User { get; set; } = null!;
}
