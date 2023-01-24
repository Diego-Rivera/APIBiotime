using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class BaseSftpsetting
{
    public int Id { get; set; }

    public string Host { get; set; } = null!;

    public int Port { get; set; }

    public string UserName { get; set; } = null!;

    public string? UserPassword { get; set; }

    public string? UserKey { get; set; }

    public short IsSftp { get; set; }
}
