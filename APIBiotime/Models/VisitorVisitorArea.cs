using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class VisitorVisitorArea
{
    public int Id { get; set; }

    public int VisitorId { get; set; }

    public int AreaId { get; set; }

    public virtual PersonnelArea Area { get; set; } = null!;

    public virtual VisitorVisitor Visitor { get; set; } = null!;
}
