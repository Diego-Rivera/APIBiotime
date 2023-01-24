using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class VisitorVisitorlog
{
    public int Id { get; set; }

    public DateTime? CreateTime { get; set; }

    public string? CreateUser { get; set; }

    public DateTime? ChangeTime { get; set; }

    public string? ChangeUser { get; set; }

    public short Status { get; set; }

    public short? VisitorStatus { get; set; }

    public int VisitorId { get; set; }

    public virtual VisitorVisitor Visitor { get; set; } = null!;
}
