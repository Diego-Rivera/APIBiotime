using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class SyncJob
{
    public int Id { get; set; }

    public DateTime? PostTime { get; set; }

    public short Flag { get; set; }

    public DateTime? UpdateTime { get; set; }

    public string? SyncRet { get; set; }

    public string JobCode { get; set; } = null!;

    public string JobName { get; set; } = null!;
}
