using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class MeetingMeetingroomdevice
{
    public int Id { get; set; }

    public int DeviceId { get; set; }

    public int? RoomId { get; set; }

    public virtual IclockTerminal Device { get; set; } = null!;

    public virtual MeetingMeetingroom? Room { get; set; }
}
