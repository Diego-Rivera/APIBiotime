using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class AttTimeinterval
{
    public int Id { get; set; }

    public string Alias { get; set; } = null!;

    public short UseMode { get; set; }

    public TimeOnly InTime { get; set; }

    public int InAheadMargin { get; set; }

    public int InAboveMargin { get; set; }

    public int OutAheadMargin { get; set; }

    public int OutAboveMargin { get; set; }

    public int Duration { get; set; }

    public short InRequired { get; set; }

    public short OutRequired { get; set; }

    public int AllowLate { get; set; }

    public int AllowLeaveEarly { get; set; }

    public double WorkDay { get; set; }

    public short EarlyIn { get; set; }

    public int MinEarlyIn { get; set; }

    public short LateOut { get; set; }

    public int MinLateOut { get; set; }

    public short OvertimeLv { get; set; }

    public short OvertimeLv1 { get; set; }

    public short OvertimeLv2 { get; set; }

    public short OvertimeLv3 { get; set; }

    public short MultiplePunch { get; set; }

    public short AvailableIntervalType { get; set; }

    public int AvailableInterval { get; set; }

    public int WorkTimeDuration { get; set; }

    public short FuncKey { get; set; }

    public short WorkType { get; set; }

    public TimeOnly DayChange { get; set; }

    public bool EnableEarlyIn { get; set; }

    public bool EnableLateOut { get; set; }

    public bool EnableOvertime { get; set; }

    public Guid? OtRule { get; set; }

    public string? ColorSetting { get; set; }

    public bool EnableMaxOtLimit { get; set; }

    public int MaxOtLimit { get; set; }

    public bool CountEarlyInInterval { get; set; }

    public bool CountLateOutInterval { get; set; }

    public int? OtPayCodeId { get; set; }

    public short OvertimePolicy { get; set; }

    public virtual ICollection<AttChangeschedule> AttChangeschedules { get; } = new List<AttChangeschedule>();

    public virtual ICollection<AttPayloadbase> AttPayloadbases { get; } = new List<AttPayloadbase>();

    public virtual ICollection<AttPayloadtimecard> AttPayloadtimecards { get; } = new List<AttPayloadtimecard>();

    public virtual ICollection<AttShiftdetail> AttShiftdetails { get; } = new List<AttShiftdetail>();

    public virtual ICollection<AttTimeintervalBreakTime> AttTimeintervalBreakTimes { get; } = new List<AttTimeintervalBreakTime>();

    public virtual AttPaycode? OtPayCode { get; set; }
}
