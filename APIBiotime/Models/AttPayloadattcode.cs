using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class AttPayloadattcode
{
    public Guid Id { get; set; }

    public DateOnly AttDate { get; set; }

    public int Week { get; set; }

    public int Weekday { get; set; }

    public string AttCodeAlias { get; set; } = null!;

    public string? AttCodeSymbol { get; set; }

    public int Duration { get; set; }

    public decimal Workday { get; set; }

    public decimal Hours { get; set; }

    public decimal Minutes { get; set; }

    public bool IsWeekly { get; set; }

    public int AttCodeId { get; set; }

    public int EmpId { get; set; }

    public int? ShiftId { get; set; }

    public Guid? TimeCardId { get; set; }

    public virtual AttAttcode AttCode { get; set; } = null!;

    public virtual AttAttshift? Shift { get; set; }
}
