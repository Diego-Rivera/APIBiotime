using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class AttPayloadpunch
{
    public string Uuid { get; set; } = null!;

    public DateOnly? AttDate { get; set; }

    public string? CorrectState { get; set; }

    public int EmpId { get; set; }

    public int? OrigId { get; set; }

    public string? SkdId { get; set; }

    public virtual PersonnelEmployee Emp { get; set; } = null!;

    public virtual IclockTransaction? Orig { get; set; }
}
