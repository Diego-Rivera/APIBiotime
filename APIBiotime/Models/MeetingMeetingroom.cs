using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class MeetingMeetingroom
{
    public int Id { get; set; }

    public DateTime? CreateTime { get; set; }

    public string? CreateUser { get; set; }

    public DateTime? ChangeTime { get; set; }

    public string? ChangeUser { get; set; }

    public short Status { get; set; }

    public string Code { get; set; } = null!;

    public string Alias { get; set; } = null!;

    public int Capacity { get; set; }

    public string Location { get; set; } = null!;

    public string? Remark { get; set; }

    public short State { get; set; }

    public bool EnableRoom { get; set; }

    public virtual ICollection<MeetingMeetingentity> MeetingMeetingentities { get; } = new List<MeetingMeetingentity>();

    public virtual ICollection<MeetingMeetingroomdevice> MeetingMeetingroomdevices { get; } = new List<MeetingMeetingroomdevice>();
}
