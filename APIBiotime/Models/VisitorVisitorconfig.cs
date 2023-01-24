using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class VisitorVisitorconfig
{
    public int Id { get; set; }

    public DateTime? CreateTime { get; set; }

    public string? CreateUser { get; set; }

    public DateTime? ChangeTime { get; set; }

    public string? ChangeUser { get; set; }

    public short Status { get; set; }

    public short QrCodePolicy { get; set; }

    public string CodePrefix { get; set; } = null!;

    public int CodeWidth { get; set; }

    public int CodeStart { get; set; }
}
