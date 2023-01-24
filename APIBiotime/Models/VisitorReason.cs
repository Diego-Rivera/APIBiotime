using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class VisitorReason
{
    public int Id { get; set; }

    public DateTime? CreateTime { get; set; }

    public string? CreateUser { get; set; }

    public DateTime? ChangeTime { get; set; }

    public string? ChangeUser { get; set; }

    public short Status { get; set; }

    public string? VisitReason { get; set; }

    public virtual ICollection<VisitorReservation> VisitorReservations { get; } = new List<VisitorReservation>();

    public virtual ICollection<VisitorVisitor> VisitorVisitors { get; } = new List<VisitorVisitor>();
}
