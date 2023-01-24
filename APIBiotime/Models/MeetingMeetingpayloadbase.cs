using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class MeetingMeetingpayloadbase
{
    public Guid Id { get; set; }

    public DateTime StartTime { get; set; }

    public DateTime EndTime { get; set; }

    public int Duration { get; set; }

    public DateOnly MeetingDate { get; set; }

    public DateTime? ClockIn { get; set; }

    public DateTime? ClockOut { get; set; }

    public int AttendedDuration { get; set; }

    public int LateIn { get; set; }

    public int EarlyOut { get; set; }

    public int Absent { get; set; }

    public int EmpId { get; set; }

    public int MeetingId { get; set; }

    public virtual PersonnelEmployee Emp { get; set; } = null!;

    public virtual MeetingMeetingentity Meeting { get; set; } = null!;
}
