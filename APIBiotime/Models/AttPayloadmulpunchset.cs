using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class AttPayloadmulpunchset
{
    public int Id { get; set; }

    public DateOnly AttDate { get; set; }

    public short? Weekday { get; set; }

    public short DataIndex { get; set; }

    public DateTime? ClockIn { get; set; }

    public int? InId { get; set; }

    public DateTime? ClockOut { get; set; }

    public int? OutId { get; set; }

    public int? TotalTime { get; set; }

    public int? WorkedTime { get; set; }

    public short DataType { get; set; }

    public int EmpId { get; set; }

    public int? TimetableId { get; set; }

    public virtual PersonnelEmployee Emp { get; set; } = null!;
}
