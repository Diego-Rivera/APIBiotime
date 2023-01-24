using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class AccAccterminal
{
    public int Id { get; set; }

    public DateTime? CreateTime { get; set; }

    public string? CreateUser { get; set; }

    public DateTime? ChangeTime { get; set; }

    public string? ChangeUser { get; set; }

    public short Status { get; set; }

    public string? DoorName { get; set; }

    public int DoorLockDelay { get; set; }

    public int DoorSensorDelay { get; set; }

    public short DoorSensorType { get; set; }

    public int DoorAlarmDelay { get; set; }

    public short RetryTimes { get; set; }

    public short ValidHoliday { get; set; }

    public int NcTimePeriod { get; set; }

    public int NoTimePeriod { get; set; }

    public short SpeakerAlarm { get; set; }

    public short DuressFunOn { get; set; }

    public short Alarm11 { get; set; }

    public short Alarm1N { get; set; }

    public short AlarmPassword { get; set; }

    public int DuressAlarmDelay { get; set; }

    public short AntiPassbackMode { get; set; }

    public short AntiDoorDirection { get; set; }

    public short VerifyMode485 { get; set; }

    public DateTime? PushTime { get; set; }

    public int TerminalId { get; set; }

    public virtual IclockTerminal Terminal { get; set; } = null!;
}
