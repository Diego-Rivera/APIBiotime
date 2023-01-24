using System;
using System.Collections.Generic;
using System.Net;

namespace APIBiotime.Models;

public partial class RestFrameworkTrackingApirequestlog
{
    public int Id { get; set; }

    public DateTime RequestedAt { get; set; }

    public int ResponseMs { get; set; }

    public string Path { get; set; } = null!;

    public IPAddress RemoteAddr { get; set; } = null!;

    public string Host { get; set; } = null!;

    public string Method { get; set; } = null!;

    public string? QueryParams { get; set; }

    public string? Data { get; set; }

    public string? Response { get; set; }

    public int? StatusCode { get; set; }

    public int? UserId { get; set; }

    public string? View { get; set; }

    public string? ViewMethod { get; set; }

    public string? Errors { get; set; }

    public string? UsernamePersistent { get; set; }

    public virtual AuthUser? User { get; set; }
}
