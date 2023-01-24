using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class MobileApplist
{
    public int Id { get; set; }

    public string Username { get; set; } = null!;

    public DateTime LoginTime { get; set; }

    public DateTime LastActive { get; set; }

    public string Token { get; set; } = null!;

    public string DeviceToken { get; set; } = null!;

    public string ClientId { get; set; } = null!;

    public short ClientCategory { get; set; }

    public short? Active { get; set; }

    public short? Enable { get; set; }
}
