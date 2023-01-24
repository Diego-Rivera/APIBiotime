using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class MobileAppactionlog
{
    public int Id { get; set; }

    public string User { get; set; } = null!;

    public string? Client { get; set; }

    public string? Action { get; set; }

    public string? Params { get; set; }

    public string? Describe { get; set; }

    public short RequestStatus { get; set; }

    public DateTime ActionTime { get; set; }

    public string? RemoteIp { get; set; }
}
