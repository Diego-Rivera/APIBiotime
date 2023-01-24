using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class AttPayloadpaycode
{
    public Guid Id { get; set; }

    public DateOnly AttDate { get; set; }

    public int Week { get; set; }

    public int Weekday { get; set; }

    public string PayCodeAlias { get; set; } = null!;

    public string? PayCodeSymbol { get; set; }

    public int Duration { get; set; }

    public decimal Workday { get; set; }

    public decimal Hours { get; set; }

    public decimal Minutes { get; set; }

    public bool IsWeekly { get; set; }

    public int EmpId { get; set; }

    public int PayCodeId { get; set; }

    public int? ShiftId { get; set; }

    public Guid? TimeCardId { get; set; }

    public short IsException { get; set; }

    public int Year { get; set; }

    public virtual PersonnelEmployee Emp { get; set; } = null!;

    public virtual AttPaycode PayCode { get; set; } = null!;

    public virtual AttAttshift? Shift { get; set; }
}
