using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class AttGrouppolicy
{
    public int Id { get; set; }

    public DateTime? CreateTime { get; set; }

    public string? CreateUser { get; set; }

    public DateTime? ChangeTime { get; set; }

    public string? ChangeUser { get; set; }

    public short Status { get; set; }

    public short UseOt { get; set; }

    public short Weekend1 { get; set; }

    public short Weekend2 { get; set; }

    public short StartOfWeek { get; set; }

    public decimal MaxHrs { get; set; }

    public TimeOnly DayChange { get; set; }

    public short ParingRule { get; set; }

    public short PunchPeriod { get; set; }

    public bool DailyOt { get; set; }

    public Guid? DailyOtRule { get; set; }

    public bool WeeklyOt { get; set; }

    public Guid? WeeklyOtRule { get; set; }

    public bool WeekendOt { get; set; }

    public Guid? WeekendOtRule { get; set; }

    public bool HolidayOt { get; set; }

    public Guid? HolidayOtRule { get; set; }

    public int LateIn2absence { get; set; }

    public int EarlyOut2absence { get; set; }

    public short MissIn { get; set; }

    public int LateInHrs { get; set; }

    public short MissOut { get; set; }

    public int EarlyOutHrs { get; set; }

    public bool RequireCapture { get; set; }

    public bool RequireWorkCode { get; set; }

    public bool RequirePunchState { get; set; }

    public int GroupId { get; set; }

    public TimeOnly EmailSendTime { get; set; }

    public short GroupFrequency { get; set; }

    public short GroupSendDay { get; set; }

    public short MaxAbsent { get; set; }

    public short MaxEarlyOut { get; set; }

    public short MaxLateIn { get; set; }

    public short SendingDay { get; set; }

    public string? Weekend1ColorSetting { get; set; }

    public string? Weekend2ColorSetting { get; set; }

    public int? OtPayCodeId { get; set; }

    public short OvertimePolicy { get; set; }

    public bool EnableCompensatory { get; set; }

    public virtual AttAttgroup Group { get; set; } = null!;

    public virtual AttPaycode? OtPayCode { get; set; }
}
