using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class AttAttshift
{
    public int Id { get; set; }

    public string Alias { get; set; } = null!;

    public short CycleUnit { get; set; }

    public int ShiftCycle { get; set; }

    public bool WorkWeekend { get; set; }

    public short WeekendType { get; set; }

    public bool WorkDayOff { get; set; }

    public short DayOffType { get; set; }

    public short AutoShift { get; set; }

    public bool EnableOtRule { get; set; }

    public short Frequency { get; set; }

    public Guid? OtRule { get; set; }

    public virtual ICollection<AttAttschedule> AttAttschedules { get; } = new List<AttAttschedule>();

    public virtual ICollection<AttDepartmentschedule> AttDepartmentschedules { get; } = new List<AttDepartmentschedule>();

    public virtual ICollection<AttGroupschedule> AttGroupschedules { get; } = new List<AttGroupschedule>();

    public virtual ICollection<AttPayloadattcode> AttPayloadattcodes { get; } = new List<AttPayloadattcode>();

    public virtual ICollection<AttPayloadpaycode> AttPayloadpaycodes { get; } = new List<AttPayloadpaycode>();

    public virtual ICollection<AttShiftdetail> AttShiftdetails { get; } = new List<AttShiftdetail>();
}
