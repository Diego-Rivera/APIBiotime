using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class IclockShortmessage
{
    public int Id { get; set; }

    public string Message { get; set; } = null!;

    public DateTime StartTime { get; set; }

    public int Duration { get; set; }

    public string MsgType { get; set; } = null!;

    public virtual ICollection<IclockPrivatemessage> IclockPrivatemessages { get; } = new List<IclockPrivatemessage>();

    public virtual ICollection<IclockPublicmessage> IclockPublicmessages { get; } = new List<IclockPublicmessage>();
}
