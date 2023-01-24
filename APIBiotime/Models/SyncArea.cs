using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class SyncArea
{
    public int Id { get; set; }

    public DateTime? PostTime { get; set; }

    public short Flag { get; set; }

    public DateTime? UpdateTime { get; set; }

    public string? SyncRet { get; set; }

    public string AreaCode { get; set; } = null!;

    public string AreaName { get; set; } = null!;
}
