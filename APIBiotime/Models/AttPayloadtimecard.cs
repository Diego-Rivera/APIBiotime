using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class AttPayloadtimecard
{
    public Guid Id { get; set; }

    public DateOnly AttDate { get; set; }

    public int Week { get; set; }

    public int Weekday { get; set; }

    public short DateType { get; set; }

    public string TimeTableAlias { get; set; } = null!;

    public DateTime CheckIn { get; set; }

    public DateTime CheckOut { get; set; }

    public decimal WorkDay { get; set; }

    public DateTime? ClockIn { get; set; }

    public DateTime? ClockOut { get; set; }

    public DateTime? BreakOut { get; set; }

    public DateTime? BreakIn { get; set; }

    public bool LockDown { get; set; }

    public int EmpId { get; set; }

    public int? TimeTableId { get; set; }

    public short Present { get; set; }

    public short FullAttendance { get; set; }

    public virtual AttTimeinterval? TimeTable { get; set; }
}
