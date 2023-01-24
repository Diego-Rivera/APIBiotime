using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class AttPayloadexception
{
    public string Uuid { get; set; } = null!;

    public DateTime StartTime { get; set; }

    public DateTime EndTime { get; set; }

    public int? Duration { get; set; }

    public double? Days { get; set; }

    public short DataType { get; set; }

    public string? Description { get; set; }

    public int? ItemId { get; set; }

    public string? SkdId { get; set; }

    public virtual AttLeave? Item { get; set; }
}
