using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class AttPayloadparing
{
    public Guid Id { get; set; }

    public long Stamp { get; set; }

    public DateOnly AttDate { get; set; }

    public short Week { get; set; }

    public short Weekday { get; set; }

    public short DataType { get; set; }

    public DateTime? ClockIn { get; set; }

    public DateOnly? InDate { get; set; }

    public TimeOnly? InTime { get; set; }

    public DateTime? ClockOut { get; set; }

    public DateOnly? OutDate { get; set; }

    public TimeOnly? OutTime { get; set; }

    public int Duration { get; set; }

    public int WorkedDuration { get; set; }

    public int DataIndex { get; set; }

    public decimal Workday { get; set; }

    public int EmpId { get; set; }

    public int? InTransId { get; set; }

    public int? OutTransId { get; set; }

    public int? PayCodeId { get; set; }

    public Guid? TimeCardId { get; set; }

    public virtual PersonnelEmployee Emp { get; set; } = null!;

    public virtual IclockTransaction? InTrans { get; set; }

    public virtual IclockTransaction? OutTrans { get; set; }

    public virtual AttPaycode? PayCode { get; set; }
}
